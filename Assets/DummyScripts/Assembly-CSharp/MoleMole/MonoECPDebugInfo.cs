/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoECPDebugInfo : MonoBehaviour // TypeDefIndex: 27814
	{
		// Fields
		private GUIStyle _style; // 0x18
		private Rect _drawArea; // 0x20
		private const float STATWIDGET_PENDING = 100f; // Metadata: 0x00B0CFA4
		private GUIStyle _defaultAreaStyle; // 0x30
		private Vector2 scrollPosition; // 0x38
		private List<StatRichString> _cachedToDisplayDebugInfos; // 0x40
		private MonoGUIWidget_Popup _watchModeSelector; // 0x48
		private MonoGUIWidget_Popup _entityTypeFilter; // 0x50
		private const string idAppendPrefix = "     "; // Metadata: 0x00B0CFA8
	
		// Properties
		private EWatchMode _currentWatchMode { /* [XID] */ /* 0x00000001897D9AD0-0x00000001897D9AF0 */ get => default; } // 0x00000001846962B0-0x0000000184696370 
		private BaseEntity.ECPDebugInfo.EFilterEntityType _targetFilterType { /* [XID] */ /* 0x00000001897E0D70-0x00000001897E0D90 */ get => default; } // 0x00000001846976C0-0x0000000184697780 
	
		// Nested types
		private struct StatRichString // TypeDefIndex: 27815
		{
			// Fields
			public Color color; // 0x00
			public string str; // 0x10
			public bool needIndex; // 0x18
		}
	
		public enum EWatchMode // TypeDefIndex: 27816
		{
			EWM_EntityTickTime = 0,
			EWM_EntityToken = 1
		}
	
		[Serializable]
		public class FrameEntityCatergoryCountPlainData // TypeDefIndex: 27817
		{
			// Fields
			public string name; // 0x10
			public string type; // 0x18
			public int count; // 0x20
	
			// Constructors
			public FrameEntityCatergoryCountPlainData() {} // Dummy constructor
			public FrameEntityCatergoryCountPlainData(BaseEntity.ECPDebugInfo inInfo) {} // 0x00000001846907B0-0x00000001846909C0
		}
	
		// Constructors
		public MonoECPDebugInfo() {} // 0x0000000184698900-0x0000000184698A00
	
		// Methods
		// [XID] // 0x00000001897BB550-0x00000001897BB570
		public static MonoECPDebugInfo CreateInstance() => default; // 0x00000001846964B0-0x0000000184696580
		// [XID] // 0x00000001897C2D70-0x00000001897C2D90
		private void Start() {} // 0x0000000184698080-0x0000000184698860
		// [XID] // 0x00000001897CA5A0-0x00000001897CA5C0
		private void Update() {} // 0x0000000184698860-0x0000000184698900
		// [XID] // 0x00000001897D1BD0-0x00000001897D1BF0
		private void Awake() {} // 0x00000001846960C0-0x00000001846962B0
		// [XID] // 0x00000001897E83F0-0x00000001897E8410
		public static float GenerateCatergroyEntityTickList(List<FrameEntityCatergoryCountPlainData> inData) => default; // 0x0000000184697250-0x00000001846976C0
		// [XID] // 0x00000001897F0110-0x00000001897F0130
		public static void DumpCSV(List<CycleStatLogNode> _cycleStatLogs) {} // 0x0000000184696580-0x0000000184696740
		// [XID] // 0x00000001897F7880-0x00000001897F78A0
		private void OnGenerateEntityTickStatLog(List<CycleStatLogNode> _cycleStatLogs) {} // 0x0000000184696D70-0x00000001846971D0
		// [XID] // 0x00000001897FEFB0-0x00000001897FEFD0
		private void OnGenerateEntityTokenStatLog() {} // 0x0000000184695BE0-0x00000001846960C0
		// [XID] // 0x0000000189806710-0x0000000189806730
		private static string GenerateCategoryEntityTickTimeDebugCSVString(ref BaseEntity.ECPDebugInfo inECP, out Color displayColor) {
			displayColor = default;
			return default;
		} // 0x0000000184697780-0x00000001846978A0
		[DebuggerHidden] // 0x000000018980DE90-0x000000018980DED0
		// [XID] // 0x000000018980DE90-0x000000018980DED0
		private IEnumerator RefreshEntityECPInfo() => default; // 0x0000000184696C60-0x0000000184696D70
		// [XID] // 0x0000000189818910-0x0000000189818930
		public void Close() {} // 0x0000000184696370-0x00000001846964B0
		// [XID] // 0x00000001898201C0-0x00000001898201E0
		public static string DumpEntityTokenToCSV(int mode, bool openFolder = false /* Metadata: 0x00B0CFA3 */) => default; // 0x0000000184696820-0x0000000184696C60
		// [XID] // 0x0000000189827740-0x0000000189827760
		public static string DumpEntityTokenToCSVAndUpload(int mode) => default; // 0x0000000184696740-0x0000000184696820
		// [XID] // 0x000000018982E9C0-0x000000018982E9E0
		private void OnGUIDumpAsCSV() {} // 0x00000001846978A0-0x0000000184697B30
		// [XID] // 0x0000000189836320-0x0000000189836340
		private void OnGUI() {} // 0x0000000184697B30-0x0000000184698080
	}
}
