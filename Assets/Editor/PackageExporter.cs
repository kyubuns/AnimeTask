using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Development
{
    public static class PackageExporter
    {
        private const string Target = "Assets/AnimeTask";

        [MenuItem("Export/Package")]
        public static void Export()
        {
            var packageText = AssetDatabase.LoadAssetAtPath<TextAsset>(Path.Combine(Target, "package.json"));
            var package = JsonUtility.FromJson<PackageJson>(packageText.text);

            var outputPath = Path.Combine(Path.GetDirectoryName(Application.dataPath) ?? "", $"{package.displayName}_v{package.version}.unitypackage");
            AssetDatabase.ExportPackage(new[] { Target }, outputPath, ExportPackageOptions.Recurse);
            Debug.LogFormat("ExportPackage {0}", outputPath);
        }
    }

    [Serializable]
    public class PackageJson
    {
        public string displayName;
        public string version;
    }
}