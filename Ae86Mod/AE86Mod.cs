using BepInEx;
using Ae86Mod.Survivors.Ae86;
using R2API.Utils;
using RoR2;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace Ae86Mod {
    //[BepInDependency("com.rune580.riskofoptions", BepInDependency.DependencyFlags.SoftDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    public class Ae86Plugin : BaseUnityPlugin {
        public const string MODUID = "com.Test.Ae86Mod";
        public const string MODNAME = "Ae86Mod";
        public const string MODVERSION = "1.0.0";
        public const string DEVELOPER_PREFIX = "TEST"; // a prefix for name tokens to prevent conflicts- please capitalize all name tokens for convention

        public static Ae86Plugin instance;

        void Awake() {
            instance = this;
            Log.Init(Logger);
            Modules.Language.Init();
            new Ae86Survivor().Initialize();
            new Modules.ContentPacks().Initialize(); // this has to be last
        }
    }
}