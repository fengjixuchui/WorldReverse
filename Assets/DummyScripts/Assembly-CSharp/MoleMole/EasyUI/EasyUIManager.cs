/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.EasyUI
{
	public sealed class EasyUIManager // TypeDefIndex: 28568
	{
		// Fields
		private static EasyUIManager _instance; // 0x00
		private Dictionary<string, BaseEasyContext> _dict; // 0x10
		private Stack<BaseEasyContext> _stack; // 0x18
		private MonoEasyUIManager _mono; // 0x20
		private uint handle; // 0x28
		private readonly string OPTIMIZE_CONSOLE_NAME; // 0x30
	
		// Properties
		public static EasyUIManager Instance { /* [XID] */ /* 0x00000001897A88C0-0x00000001897A88E0 */ get => default; } // 0x000000018149A330-0x000000018149A400 
	
		// Constructors
		private EasyUIManager() {} // 0x000000018149A050-0x000000018149A330
		static EasyUIManager() {} // 0x0000000181499FD0-0x000000018149A050
	
		// Methods
		~EasyUIManager() {} // 0x00000001814962C0-0x00000001814963A0
		// [IDTag] // 0x00000001897B0380-0x00000001897B03C0
		// [XID] // 0x00000001897B0380-0x00000001897B03C0
		public void Push(string name) {} // 0x00000001814979F0-0x0000000181497BC0
		// [IDTag] // 0x00000001897BB490-0x00000001897BB4D0
		// [XID] // 0x00000001897BB490-0x00000001897BB4D0
		private void Push(BaseEasyContext context) {} // 0x0000000181497BC0-0x0000000181497D70
		// [XID] // 0x00000001897C6000-0x00000001897C6020
		public void Pop(bool isClearView = false /* Metadata: 0x00B0D93A */) {} // 0x00000001814977E0-0x00000001814979F0
		// [XID] // 0x00000001897CD840-0x00000001897CD860
		public void Clear() {} // 0x00000001814932D0-0x0000000181493620
		// [XID] // 0x00000001897D4D60-0x00000001897D4D80
		public void Remove(string name) {} // 0x0000000181497D70-0x00000001814980D0
		// [XID] // 0x00000001897DC4C0-0x00000001897DC4E0
		public EasyOptimizeContext CreateOptimizeContext(string name) => default; // 0x0000000181494D60-0x0000000181495090
		// [XID] // 0x00000001897E3EB0-0x00000001897E3ED0
		public EasyOptimizeContext GetOptimizeContext(string name) => default; // 0x00000001814976E0-0x00000001814977E0
		// [XID] // 0x00000001897EBA00-0x00000001897EBA20
		public GameObject CreateButtonPrefab() => default; // 0x0000000181493820-0x0000000181493940
		// [XID] // 0x00000001897F3300-0x00000001897F3320
		public GameObject CreateTogglePrefab() => default; // 0x0000000181495CB0-0x0000000181495DD0
		// [XID] // 0x00000001897FAB70-0x00000001897FAB90
		public GameObject CreateSliderPrefab() => default; // 0x0000000181495A70-0x0000000181495B90
		// [XID] // 0x0000000189802120-0x0000000189802140
		public GameObject CreateDropdownPrefab() => default; // 0x0000000181493940-0x0000000181493A60
		// [XID] // 0x00000001898095F0-0x0000000189809610
		public GameObject CreateInputFieldPrefab() => default; // 0x0000000181493F70-0x0000000181494090
		// [XID] // 0x0000000189810DE0-0x0000000189810E00
		public GameObject CreateSliderWithInputPrefab() => default; // 0x0000000181495B90-0x0000000181495CB0
		// [XID] // 0x0000000189818890-0x00000001898188B0
		private bool CheckIsNullPrefab(GameObject go, string msg) => default; // 0x00000001814931A0-0x00000001814932D0
		// [XID] // 0x0000000189820160-0x0000000189820180
		private EasyOptimizeContext CreateSliceFrameWatchPage() => default; // 0x0000000181495680-0x0000000181495A70
		// [XID] // 0x0000000189827700-0x0000000189827720
		private EasyOptimizeContext CreateObjectPoolPage() => default; // 0x0000000181494280-0x0000000181494D60
		// [XID] // 0x000000018982E940-0x000000018982E960
		private EasyOptimizeContext CreateTokenPage() => default; // 0x0000000181495DD0-0x00000001814962C0
		// [XID] // 0x00000001898362E0-0x0000000189836300
		private EasyOptimizeContext CreateMassiveStatPage() => default; // 0x0000000181494090-0x0000000181494280
		// [XID] // 0x000000018983D730-0x000000018983D750
		private EasyOptimizeContext CreateDumpStatPage() => default; // 0x0000000181493A60-0x0000000181493F70
		// [XID] // 0x0000000189844F50-0x0000000189844F70
		private EasyOptimizeContext CreatePowerStatPage() => default; // 0x0000000181495090-0x0000000181495680
		// [XID] // 0x000000018984C440-0x000000018984C460
		private EasyOptimizeContext CreateAnimationPage() => default; // 0x0000000181493620-0x0000000181493820
		// [XID] // 0x0000000189853550-0x0000000189853570
		public void GenerateOptimizeConsole() {} // 0x00000001814972B0-0x00000001814976E0
		// [XID] // 0x000000018985AFC0-0x000000018985AFE0
		private void GenerateDemoConsole() {} // 0x00000001814963A0-0x00000001814972B0
	}
}
