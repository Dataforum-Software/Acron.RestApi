using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{

   public static class ProviderObjectDefines
   {
      #region Driver IDs

      //ProviderDriverObject
      public const int DrvZenon = 8000000;
      public const int DrvWizcon52 = 8000001;
      public const int DrvWincctl = 8000002;
      public const int DrvWinccflexalat = 8000003;
      public const int DrvWinccdb = 8000004;
      public const int DrvWincc60 = 8000005;
      public const int DrvText_uni = 8000006;
      public const int DrvSimulate = 8000007;
      public const int DrvSattgraph90 = 8000008;
      public const int DrvSattgraph5000_values = 8000009;
      public const int DrvSattgraph5000_alarms = 8000010;
      public const int DrvProcos = 8000011;
      public const int DrvOpchda = 8000012;
      public const int DrvOpcclientua = 8000013;
      public const int DrvOpcclientts = 8000014;
      public const int DrvOpcclient = 8000015;
      public const int DrvOpcaeclient = 8000016;
      public const int DrvOdbc_uni_al = 8000017;
      public const int DrvOdbc_uni = 8000018;
      public const int DrvIntouchalarm = 8000019;
      public const int DrvGmecs = 8000020;
      public const int DrvFlalarms = 8000021;
      public const int DrvFixdyn = 8000022;
      public const int DrvFix60 = 8000023;
      public const int DrvFile = 8000024;
      public const int DrvEon_oracle_knepper = 8000025;
      public const int DrvDdefast = 8000026;
      public const int DrvDdeevent = 8000027;
      public const int DrvDdecyc = 8000028;
      public const int DrvDdeadv = 8000029;
      public const int DrvBabcock = 8000030;
      public const int DrvAlarmuni = 8000031;
      public const int DrvWincc72 = 8000032;
      public const int DrvOpcclientua_ts = 8000033;
      public const int DrvAcronToAcron = 8000034;
      public const int DrvSimulate64 = 8000035;
      public const int DrvWinccUni64 = 8000036;
      public const int DrvSysInfo64 = 8000037;
      public const int DrvOpcclientua64 = 8000038; // NEU - 64Bit und immer mit TS

      public const int MinDriverId = DrvZenon;
      public const int MaxDriverId = DrvOpcclientua64; // !!! Always compensate the last driver !!!

      #endregion Driver IDs
   }

   /// <summary>
   /// Interface for the provider objects (Base only; no instances)
   /// </summary>
   public interface IProviderObject : IProviderBaseObject
   {
      /// <summary> Base object ID of the corresponding driver </summary>
      [SwaggerSchema("Base object id of the corresponding driver")]
      [SwaggerExampleValue("100000003")]

      int PropIdDriver
      {
         get; set;
      }

      /// <summary> Driver parameter 1 </summary>
      [SwaggerSchema("Driver parameter 1")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter1
      {
         get; set;
      }

      /// <summary> Driver parameter 2 </summary>
      /// 
      [SwaggerSchema("Driver parameter 2")]
      [SwaggerExampleValue("50")]
      string PropDriverParameter2
      {
         get; set;
      }

      /// <summary> Driver parameter 3 </summary>
      /// 
      [SwaggerSchema("Driver parameter 3")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter3
      {
         get; set;
      }

      /// <summary> Driver parameter 4 </summary>
      /// 
      [SwaggerSchema("Driver parameter 4")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter4
      {
         get; set;
      }

      /// <summary> Driver parameter 5 </summary>
      /// 
      [SwaggerSchema("Driver parameter 5")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter5
      {
         get; set;
      }

      /// <summary> Measurement interval (ms) </summary>
      /// 
      [SwaggerSchema("Measurement interval (ms)")]
      [SwaggerExampleValue("0")]
      int PropReadingInterval
      {
         get; set;
      }

      /// <summary> Query delay after start (s) </summary>
      /// 
      [SwaggerSchema("Query delay after start (s)")]
      [SwaggerExampleValue("0")]
      int PropStartupDelayTime
      {
         get; set;
      }

      /// <summary> Test mode </summary>
      /// 
      [SwaggerSchema("Test mode")]
      [SwaggerExampleValue("false")]
      bool PropTestMode
      {
         get; set;
      }

      /// <summary> Window always in foreground </summary>
      /// 
      [SwaggerSchema("Window always in foreground")]
      [SwaggerExampleValue("false")]
      bool PropAlwaysOnTop
      {
         get; set;
      }

      /// <summary> Create alerts automatically </summary>
      /// 
      [SwaggerSchema("Create alerts automatically")]
      [SwaggerExampleValue("true")]
      bool PropAlertAutoGeneration
      {
         get; set;
      }

      /// <summary> Composition rule group names </summary>
      /// 
      [SwaggerSchema("Composition rule group names")]
      [SwaggerExampleValue("$GroupName")]
      string PropAlertRuleGroupName
      {
         get; set;
      }

      /// <summary> Composition rule variable names </summary>
      /// 
      [SwaggerSchema("Composition rule variable names")]
      [SwaggerExampleValue("$VarName")]
      string PropAlertRuleVarName
      {
         get; set;
      }

   }
}