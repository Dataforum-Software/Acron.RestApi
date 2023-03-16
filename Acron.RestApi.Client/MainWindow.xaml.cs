using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acron.RestApi.Client
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         DoAction();
      }

      private List<RestClient> clients = new List<RestClient>();

      private void DoAction()
      {
         int maxClients = 1;
         int maxClientIterations = 1000;
         List<Task> tasks = new List<Task>();

         System.Diagnostics.Stopwatch resultStopWatch = new System.Diagnostics.Stopwatch();
         resultStopWatch.Start();


         for (int i = 0; i < maxClients; i++)
         {
            RestClient client = new RestClient($"RestClient #{i + 1}", "enternix-kfr.dataforum.local", 3900, "App1Name", "App1Password", "", "");
            clients.Add(client);
         }

         for (int i = 0; i < maxClients; i++)
         {
            Task task = WaitForClientReady(i);
            tasks.Add(task);
         }
         Task.WaitAll(tasks.ToArray());
         tasks.Clear();


         for (int i = 0; i < maxClients; i++)
         {
            Task task = TaskMethod(i, maxClientIterations);
            tasks.Add(task);
         }
         Task.WaitAll(tasks.ToArray());

         resultStopWatch.Stop();
         System.Diagnostics.Debug.WriteLine("#####################################");
         System.Diagnostics.Debug.WriteLine($"TotalTime: {resultStopWatch.ElapsedMilliseconds}");
         System.Diagnostics.Debug.WriteLine($"Durchschnitt Request: {resultStopWatch.ElapsedMilliseconds / maxClientIterations }");
      }

      private Task WaitForClientReady(int pClientID)
      {
         return Task.Run(() => 
         {
            while (!clients[pClientID].ClientReady)
            {
               Thread.Sleep(50);
            }
         });
      }

      private Task TaskMethod(int pClientID, int pMaxIterations)
      {
         return Task.Run(async () =>
         {            
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            int cmdIter = 0;
            while (cmdIter < pMaxIterations)
            {
               sw.Restart();
               (bool HasError, string ErrorText, string Result) = await clients[pClientID].GetData(50);
               sw.Stop();
               if (HasError)
               {
                  System.Diagnostics.Debug.WriteLine($"{DateTime.Now}:  ERROR {clients[pClientID].RestClientName}: {ErrorText} | ClientStopWatch Time: {sw.ElapsedMilliseconds}");
               }
               else
               {
                  System.Diagnostics.Debug.WriteLine($"{DateTime.Now}:  Result {clients[pClientID].RestClientName}: {Result} | ClientStopWatch Time: {sw.ElapsedMilliseconds}");
               }
               cmdIter++;
            }
         });
      }
   }
}
