using UnityEditor;


namespace UnityGameFramework.Editor
{
    public static class CustomsScriptingDefineSymbols
    {
        private const string OverrideNoInternal = "OVERRIDE_NO_INTERNAL";

        /// <summary>
        /// 禁用所有日志脚本宏定义。
        /// </summary>
        [MenuItem("Game Framework/Scripting Define Symbols/Disable Override No Internal", false, 50)]
        public static void DisableAllLogs()
        {
            ScriptingDefineSymbols.RemoveScriptingDefineSymbol(OverrideNoInternal); 
        }

        /// <summary>
        /// 开启所有日志脚本宏定义。
        /// </summary>
        [MenuItem("Game Framework/Scripting Define Symbols/Enable Override No Internal", false, 51)]
        public static void EnableAllLogs()
        { 
            ScriptingDefineSymbols.AddScriptingDefineSymbol(OverrideNoInternal);
        }
    }

}
