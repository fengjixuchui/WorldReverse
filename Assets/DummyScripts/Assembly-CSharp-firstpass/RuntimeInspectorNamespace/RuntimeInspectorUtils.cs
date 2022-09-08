/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public static class RuntimeInspectorUtils // TypeDefIndex: 10033
	{
		// Fields
		private static Dictionary<System.Type, MemberInfo[]> typeToVariables; // 0x00
		private static Dictionary<System.Type, ExposedMethod[]> typeToExposedMethods; // 0x08
		private static HashSet<System.Type> serializableUnityTypes; // 0x10
		private static List<ExposedExtensionMethodHolder> exposedExtensionMethods; // 0x18
		private static Canvas m_draggedReferenceItemsCanvas; // 0x20
	
		// Properties
		public static System.Type ExposedExtensionMethodsHolder { get; /* [XID] */ /* 0x0000000189601CB0-0x0000000189601CD0 */ set; } // 0x000000018674B8A0-0x000000018674B960
		public static Canvas DraggedReferenceItemsCanvas { /* [XID] */ /* 0x0000000189609580-0x00000001896095A0 */ get; } // 0x000000018674B4C0-0x000000018674B8A0 
	
		// Constructors
		static RuntimeInspectorUtils() {} // 0x000000018674B160-0x000000018674B4C0
	
		// Methods
		// [XID] // 0x000000018964F870-0x000000018964F890
		public static DraggedReferenceItem CreateDraggedReferenceItem(UnityEngine.Object reference, PointerEventData draggingPointer, UISkin skin = null) => default; // 0x0000000186748210-0x00000001867483B0
		// [XID] // 0x0000000189741C40-0x0000000189741C60
		public static UnityEngine.Object GetAssignableObjectFromDraggedReferenceItem(PointerEventData draggingPointer, System.Type assignableType) => default; // 0x00000001867489A0-0x0000000186748E00
		// [XID] // 0x000000018965E8B0-0x000000018965E8D0
		private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1) {} // 0x000000018674A870-0x000000018674AA30
		// [XID] // 0x0000000189B74D90-0x0000000189B74DB0
		public static System.Type GetType(string typeName) => default; // 0x0000000186749D30-0x000000018674A070
		// [XID] // 0x0000000189A8B650-0x0000000189A8B670
		private static void GetExposedExtensionMethods(System.Type type) {} // 0x0000000186748E00-0x0000000186749250
	
		// Extension methods
		// [XID] // 0x0000000189610CE0-0x0000000189610D20
		public static bool IsNull(this object obj) => default; // 0x000000018674A210-0x000000018674A320
		// [XID] // 0x000000018961B330-0x000000018961B370
		public static string ToTitleCase(this string str) => default; // 0x000000018674AD90-0x000000018674B160
		// [XID] // 0x00000001896258C0-0x0000000189625900
		public static string GetName(this UnityEngine.Object obj) => default; // 0x0000000186749AA0-0x0000000186749BB0
		// [XID] // 0x00000001896301F0-0x0000000189630230
		public static string GetNameWithType(this object obj, System.Type defaultType = null) => default; // 0x0000000186749800-0x0000000186749AA0
		// [XID] // 0x000000018963ABB0-0x000000018963ABF0
		public static Texture GetTexture(this UnityEngine.Object obj) => default; // 0x0000000186749BB0-0x0000000186749D30
		// [XID] // 0x00000001896451C0-0x0000000189645200
		public static Color Tint(this Color color, float tintAmount) => default; // 0x000000018674AC60-0x000000018674AD90
		// [XID] // 0x0000000189665F20-0x0000000189665F60
		public static bool IsPointerValid(this PointerEventData eventData) => default; // 0x000000018674A320-0x000000018674A530
		// [XID] // 0x0000000189670C80-0x0000000189670CC0
		public static MemberInfo[] GetAllVariables(this System.Type type) => default; // 0x00000001867483B0-0x00000001867489A0
		// [XID] // 0x000000018967B3A0-0x000000018967B3E0
		public static ExposedMethod[] GetExposedMethods(this System.Type type) => default; // 0x0000000186749250-0x0000000186749800
		// [XID] // 0x0000000189685BB0-0x0000000189685BF0
		public static bool ShouldExposeInInspector(this MemberInfo variable, bool debugMode) => default; // 0x000000018674AA30-0x000000018674AC60
		// [XID] // 0x0000000189690BA0-0x0000000189690BE0
		private static bool IsSerializable(this System.Type type) => default; // 0x000000018674A530-0x000000018674A870
		// [XID] // 0x000000018969AF30-0x000000018969AF70
		public static object Instantiate(this System.Type type) => default; // 0x000000018674A070-0x000000018674A210
	}
}
