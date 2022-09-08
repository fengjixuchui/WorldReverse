/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullInspector;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public static class fiLateBindings // TypeDefIndex: 4984
	{
		// Nested types
		public static class _Bindings // TypeDefIndex: 4985
		{
			// Fields
			public static Func<bool> _EditorApplication_isPlaying; // 0x00
			public static Func<bool> _EditorApplication_isCompilingOrChangingToPlayMode; // 0x08
			public static Action<Action> _EditorApplication_InvokeOnEditorThread; // 0x10
			public static Action<Action> _EditorApplication_AddUpdateAction; // 0x18
			public static Action<Action> _EditorApplication_RemUpdateAction; // 0x20
			public static Func<double> _EditorApplication_timeSinceStartup; // 0x28
			public static Action<UnityEngine.Object> _EditorUtility_SetDirty; // 0x30
			public static Func<int, UnityEngine.Object> _EditorUtility_InstanceIdToObject; // 0x38
			public static Action _EditorGUI_BeginChangeCheck; // 0x40
			public static Func<bool> _EditorGUI_EndChangeCheck; // 0x48
			public static Action<bool> _EditorGUI_BeginDisabledGroup; // 0x50
			public static Action _EditorGUI_EndDisabledGroup; // 0x58
			public static _EditorGUI_Foldout_Type _EditorGUI_Foldout; // 0x60
			public static Action<Rect, string, CommentType> _EditorGUI_HelpBox; // 0x68
			public static _EditorGUI_Slider_Type<int> _EditorGUI_IntSlider; // 0x70
			public static _EditorGUI_PopupType _EditorGUI_Popup; // 0x78
			public static _EditorGUI_Slider_Type<float> _EditorGUI_Slider; // 0x80
			public static Func<GUIStyle> _EditorStyles_label; // 0x88
			public static Func<GUIStyle> _EditorStyles_foldout; // 0x90
			public static Action<bool> _fiEditorGUI_PushHierarchyMode; // 0x98
			public static Action _fiEditorGUI_PopHierarchyMode; // 0xA0
			public static _PropertyEditor_Edit_Type _PropertyEditor_Edit; // 0xA8
			public static _PropertyEditor_GetElementHeight_Type _PropertyEditor_GetElementHeight; // 0xB0
			public static _PropertyEditor_EditSkipUntilNot_Type _PropertyEditor_EditSkipUntilNot; // 0xB8
			public static _PropertyEditor_GetElementHeightSkipUntilNot_Type _PropertyEditor_GetElementHeightSkipUntilNot; // 0xC0
			public static Func<UnityEngine.Object> _Selection_activeObject; // 0xC8
			public static Func<UnityEngine.Object[]> _Selection_activeSelection; // 0xD0
	
			// Nested types
			public delegate bool _EditorGUI_Foldout_Type(Rect rect, bool status, GUIContent label, bool toggleOnLabelClick, GUIStyle style); // TypeDefIndex: 4986; 0x0000000185CF85D0-0x0000000185CF88D0
	
			public delegate T _EditorGUI_Slider_Type<T>(Rect position, GUIContent label, T value, T leftValue, T rightValue); // TypeDefIndex: 4987; 0x00000000-0x00000000
	
			public delegate int _EditorGUI_PopupType(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions); // TypeDefIndex: 4988; 0x0000000185CF8AD0-0x0000000185CF8D80
	
			public delegate object _PropertyEditor_Edit_Type(System.Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata, System.Type[] skippedEditors); // TypeDefIndex: 4989; 0x0000000185CF9690-0x0000000185CF9B80
	
			public delegate float _PropertyEditor_GetElementHeight_Type(System.Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata, System.Type[] skippedEditors); // TypeDefIndex: 4990; 0x0000000185CFA440-0x0000000185CFA8F0
	
			public delegate object _PropertyEditor_EditSkipUntilNot_Type(System.Type[] skipUntilNot, System.Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata); // TypeDefIndex: 4991; 0x0000000185CF8F90-0x0000000185CF9480
	
			public delegate float _PropertyEditor_GetElementHeightSkipUntilNot_Type(System.Type[] skipUntilNot, System.Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata); // TypeDefIndex: 4992; 0x0000000185CF9D80-0x0000000185CFA230
		}
	
		public static class EditorApplication // TypeDefIndex: 4993
		{
			// Properties
			public static bool isPlaying { get; } // 0x0000000185CEA790-0x0000000185CEA840 
			public static bool isCompilingOrChangingToPlayMode { get; } // 0x0000000185CEA6E0-0x0000000185CEA790 
			public static double timeSinceStartup { get; } // 0x0000000185CEA840-0x0000000185CEA900 
	
			// Methods
			public static void InvokeOnEditorThread(Action func) {} // 0x0000000185CEA580-0x0000000185CEA630
			public static void AddUpdateFunc(Action func) {} // 0x0000000185CEA4D0-0x0000000185CEA580
			public static void RemUpdateFunc(Action func) {} // 0x0000000185CEA630-0x0000000185CEA6E0
		}
	
		public static class EditorUtility // TypeDefIndex: 4994
		{
			// Methods
			public static void SetDirty(UnityEngine.Object unityObject) {} // 0x0000000185CEB350-0x0000000185CEB400
			public static UnityEngine.Object InstanceIDToObject(int instanceId) => default; // 0x0000000185CEB290-0x0000000185CEB350
		}
	
		public static class EditorGUI // TypeDefIndex: 4995
		{
			// Methods
			public static void BeginChangeCheck() {} // 0x0000000185CEA970-0x0000000185CEAA10
			public static bool EndChangeCheck() => default; // 0x0000000185CEAAC0-0x0000000185CEAB70
			public static void BeginDisabledGroup(bool disabled) {} // 0x0000000185CEAA10-0x0000000185CEAAC0
			public static void EndDisabledGroup() {} // 0x0000000185CEAB70-0x0000000185CEAC10
			public static bool Foldout(Rect rect, bool state, GUIContent label, bool toggleOnLabelClick, GUIStyle style) => default; // 0x0000000185CEAC10-0x0000000185CEAD10
			public static void HelpBox(Rect rect, string message, CommentType commentType) {} // 0x0000000185CEAD10-0x0000000185CEADF0
			public static int IntSlider(Rect position, GUIContent label, int value, int leftValue, int rightValue) => default; // 0x0000000185CEADF0-0x0000000185CEAEF0
			public static int Popup(Rect position, GUIContent label, int selectedIndex, GUIContent[] displayedOptions) => default; // 0x0000000185CEAEF0-0x0000000185CEAFE0
			public static float Slider(Rect position, GUIContent label, float value, float leftValue, float rightValue) => default; // 0x0000000185CEAFE0-0x0000000185CEB0F0
		}
	
		public static class EditorGUIUtility // TypeDefIndex: 4996
		{
			// Fields
			public static float standardVerticalSpacing; // 0x00
			public static float singleLineHeight; // 0x04
	
			// Constructors
			static EditorGUIUtility() {} // 0x0000000185CEA900-0x0000000185CEA970
		}
	
		public static class EditorStyles // TypeDefIndex: 4997
		{
			// Properties
			public static GUIStyle label { get; } // 0x0000000185CEB1C0-0x0000000185CEB290 
			public static GUIStyle foldout { get; } // 0x0000000185CEB0F0-0x0000000185CEB1C0 
		}
	
		public static class fiEditorGUI // TypeDefIndex: 4998
		{
			// Methods
			public static void PushHierarchyMode(bool state) {} // 0x0000000185CFC3A0-0x0000000185CFC450
			public static void PopHierarchyMode() {} // 0x0000000185CFC2F0-0x0000000185CFC3A0
		}
	
		public static class PropertyEditor // TypeDefIndex: 4999
		{
			// Methods
			public static object Edit(System.Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata, params /* 0x000000018989F6F0-0x000000018989F700 */ System.Type[] skippedEditors) => default; // 0x0000000185CF5520-0x0000000185CF5650
			public static float GetElementHeight(System.Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata, params /* 0x000000018989F6F0-0x000000018989F700 */ System.Type[] skippedEditors) => default; // 0x0000000185CF5760-0x0000000185CF5870
			public static object EditSkipUntilNot(System.Type[] skipUntilNot, System.Type objType, MemberInfo attrs, Rect rect, GUIContent label, object obj, fiGraphMetadataChild metadata) => default; // 0x0000000185CF53F0-0x0000000185CF5520
			public static float GetElementHeightSkipUntilNot(System.Type[] skipUntilNot, System.Type objType, MemberInfo attrs, GUIContent label, object obj, fiGraphMetadataChild metadata) => default; // 0x0000000185CF5650-0x0000000185CF5760
		}
	
		public static class Selection // TypeDefIndex: 5000
		{
			// Properties
			public static UnityEngine.Object activeObject { get; } // 0x0000000185CF5870-0x0000000185CF5930 
			public static UnityEngine.Object[] activeSelection { get; } // 0x0000000185CF5930-0x0000000185CF59F0 
		}
	
		// Methods
		private static bool VerifyBinding(string name, object obj) => default; // 0x0000000185CFF670-0x0000000185CFF760
	}
}
