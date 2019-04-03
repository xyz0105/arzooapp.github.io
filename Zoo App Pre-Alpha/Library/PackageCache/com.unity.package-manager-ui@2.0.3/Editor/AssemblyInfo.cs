using System.Runtime.CompilerServices;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

[assembly: InternalsVisibleTo("Unity.PackageManagerCaptain.Editor")]
[assembly: InternalsVisibleTo("Unity.PackageManagerUI.EditorTests")]
#if UNITY_2018_3_OR_NEWER
[assembly: UxmlNamespacePrefix("UnityEditor.PackageManager.UI", "upm")]
#endif

public class AssemblyInfo : MonoBehaviour { }