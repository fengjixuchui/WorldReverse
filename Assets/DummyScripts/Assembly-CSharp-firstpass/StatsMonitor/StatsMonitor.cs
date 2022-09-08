/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace StatsMonitor
{
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public class StatsMonitor : MonoBehaviour // TypeDefIndex: 9053
	{
		// Fields
		public const string NAME = "Stats Monitor"; // Metadata: 0x00AE5129
		public const string VERSION = "1.3.5"; // Metadata: 0x00AE513A
		internal static readonly SMAnchors anchors; // 0x00
		internal bool isFirstScene; // 0x18
		private StatsMonitorWidget _statsMonitorWidget; // 0x20
		private Canvas _canvas; // 0x28
	
		// Properties
		public static StatsMonitor instance { /* [XID] */ /* 0x00000001897AE4B0-0x00000001897AE4F0 */ get; /* [XID] */ /* 0x00000001897B8F00-0x00000001897B8F40 */ private set; } // 0x0000000186F382A0-0x0000000186F38330 0x0000000186F38330-0x0000000186F383C0
		private static StatsMonitor InternalInstance { /* [XID] */ /* 0x00000001897C3E10-0x00000001897C3E30 */ get => default; } // 0x0000000186F37FA0-0x0000000186F38170 
		public static StatsMonitorWidget Widget { /* [XID] */ /* 0x00000001899AC570-0x00000001899AC590 */ get => default; } // 0x0000000186F38170-0x0000000186F382A0 
	
		// Constructors
		public StatsMonitor() {} // 0x0000000186F37F30-0x0000000186F37FA0
		static StatsMonitor() {} // 0x0000000186F37EB0-0x0000000186F37F30
	
		// Methods
		// [XID] // 0x00000001897D2E30-0x00000001897D2E50
		public static StatsMonitor AddToScene() => default; // 0x0000000186F371A0-0x0000000186F37260
		// [XID] // 0x00000001899CA140-0x00000001899CA160
		public void SetRenderMode(SMRenderMode renderMode) {} // 0x0000000186F37C90-0x0000000186F37EB0
		// [XID] // 0x00000001897E2040-0x00000001897E2060
		private void CreateUI() {} // 0x0000000186F37580-0x0000000186F37890
		// [XID] // 0x0000000189611A40-0x0000000189611A60
		private void DisposeInternal() {} // 0x0000000186F37890-0x0000000186F379B0
		// [XID] // 0x0000000189BC5EE0-0x0000000189BC5F00
		private void Awake() {} // 0x0000000186F37260-0x0000000186F37580
		// [XID] // 0x0000000189B1C970-0x0000000189B1C990
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x0000000186F37B40-0x0000000186F37C90
		// [XID] // 0x0000000189905580-0x00000001899055A0
		private void OnDestroy() {} // 0x0000000186F379B0-0x0000000186F37B40
	}
}
