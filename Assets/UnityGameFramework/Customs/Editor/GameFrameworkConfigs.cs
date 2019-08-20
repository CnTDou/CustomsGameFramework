//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using UnityEngine;
using UnityGameFramework.Editor;
using UnityGameFramework.Editor.AssetBundleTools;

namespace UnityGameFramework.Editor
{
    public static class GameFrameworkConfigs
    {
        public const string AssetRoot = Constant.AssetRoot;

        [BuildSettingsConfigPath]
        public static string BuildSettingsConfig = Utility.Path.GetCombinePath(Application.dataPath, AssetRoot + "/Configs/BuildSettings.xml");

        [AssetBundleBuilderConfigPath]
        public static string AssetBundleBuilderConfig = Utility.Path.GetCombinePath(Application.dataPath, AssetRoot + "/Configs/AssetBundleBuilder.xml");

        [AssetBundleEditorConfigPath]
        public static string AssetBundleEditorConfig = Utility.Path.GetCombinePath(Application.dataPath, AssetRoot + "/Configs/AssetBundleEditor.xml");

        [AssetBundleCollectionConfigPath]
        public static string AssetBundleCollectionConfig = Utility.Path.GetCombinePath(Application.dataPath, AssetRoot + "/Configs/AssetBundleCollection.xml");
    }
}
