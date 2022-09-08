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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class EffectProfiler : MonoBehaviour // TypeDefIndex: 19793
	{
		// Fields
		public Button startButton; // 0x18
		public UnityEngine.UI.Text progressText; // 0x20
		public UnityEngine.UI.Text loadTimeText; // 0x28
		public UnityEngine.UI.Text playTimesText; // 0x30
		public InputField playTimesInput; // 0x38
		public UnityEngine.UI.Text instanceText; // 0x40
		public InputField instanceInput; // 0x48
		private int playTimes; // 0x50
		private int instanceCount; // 0x54
		private List<EffectItem> effectItems; // 0x58
	
		// Nested types
		private class EffectItem : IComparable<EffectItem> // TypeDefIndex: 19794
		{
			// Fields
			public ulong hash; // 0x18
			private uint handle; // 0x40
			private GameObject gameObject; // 0x48
			private List<GameObject> instances; // 0x50
	
			// Properties
			public string effectPrefabName { /* [XID] */ /* 0x0000000189A0CE60-0x0000000189A0CEA0 */ get; private set; } // 0x0000000181491920-0x0000000181491980 0x0000000181491D80-0x0000000181491DE0
			public float duration { /* [XID] */ /* 0x0000000189A1E8A0-0x0000000189A1E8E0 */ get; /* [XID] */ /* 0x0000000189A28D50-0x0000000189A28D90 */ private set; } // 0x0000000181490B50-0x0000000181490BC0 0x00000001814915E0-0x0000000181491650
			public float syncLoadTime { /* [XID] */ /* 0x0000000189A33250-0x0000000189A33290 */ get; /* [XID] */ /* 0x0000000189A3DC70-0x0000000189A3DCB0 */ private set; } // 0x0000000181491CA0-0x0000000181491D10 0x0000000181491E50-0x0000000181491EC0
			public float asyncLoadTime { /* [XID] */ /* 0x0000000189A48370-0x0000000189A483B0 */ get; /* [XID] */ /* 0x0000000189A52980-0x0000000189A529C0 */ private set; } // 0x0000000181491980-0x00000001814919F0 0x0000000181491650-0x00000001814916C0
			public float maxInsTime { /* [XID] */ /* 0x0000000189A5D420-0x0000000189A5D460 */ get; /* [XID] */ /* 0x0000000189A680F0-0x0000000189A68130 */ private set; } // 0x0000000181491DE0-0x0000000181491E50 0x0000000181491B10-0x0000000181491B80
			public float minInsTime { /* [XID] */ /* 0x0000000189A726E0-0x0000000189A72720 */ get; /* [XID] */ /* 0x0000000189A7D050-0x0000000189A7D090 */ private set; } // 0x0000000181491570-0x00000001814915E0 0x00000001814916C0-0x0000000181491730
			public float avgInsTime { /* [XID] */ /* 0x0000000189A879A0-0x0000000189A879E0 */ get; /* [XID] */ /* 0x0000000189A92160-0x0000000189A921A0 */ private set; } // 0x0000000181490AE0-0x0000000181490B50 0x00000001814918B0-0x0000000181491920
			public float setActiveTime { /* [XID] */ /* 0x0000000189A9C730-0x0000000189A9C770 */ get; /* [XID] */ /* 0x0000000189AA6E80-0x0000000189AA6EC0 */ private set; } // 0x0000000181491730-0x00000001814917A0 0x0000000181491EC0-0x0000000181491F30
			public float MemoryBytes { /* [XID] */ /* 0x0000000189AB18A0-0x0000000189AB18E0 */ get; private set; } // 0x0000000181491500-0x0000000181491570 0x0000000181491D10-0x0000000181491D80
	
			// Constructors
			public EffectItem() {} // Dummy constructor
			public EffectItem(ulong prefabHash) {} // 0x0000000181491F30-0x0000000181492200
	
			// Methods
			[DebuggerHidden] // 0x0000000189AC3C60-0x0000000189AC3CA0
			// [XID] // 0x0000000189AC3C60-0x0000000189AC3CA0
			public IEnumerator FillInstances(int instanceCount) => default; // 0x00000001814919F0-0x0000000181491B10
			[DebuggerHidden] // 0x0000000189ACE290-0x0000000189ACE2D0
			// [XID] // 0x0000000189ACE290-0x0000000189ACE2D0
			public IEnumerator FillInstancesAsync() => default; // 0x00000001814911C0-0x00000001814912D0
			[DebuggerHidden] // 0x0000000189AD8FB0-0x0000000189AD8FF0
			// [XID] // 0x0000000189AD8FB0-0x0000000189AD8FF0
			public IEnumerator PlayInstances(int times) => default; // 0x0000000181491B80-0x0000000181491CA0
			[DebuggerHidden] // 0x0000000189AE3890-0x0000000189AE38D0
			// [XID] // 0x0000000189AE3890-0x0000000189AE38D0
			public IEnumerator ClearInstances() => default; // 0x00000001814917A0-0x00000001814918B0
			// [XID] // 0x0000000189AEE360-0x0000000189AEE380
			public int CompareTo(EffectItem other) => default; // 0x00000001814912D0-0x0000000181491430
			// [XID] // 0x0000000189AF5970-0x0000000189AF5990
			public static string Title(string seperate) => default; // 0x0000000181491430-0x0000000181491500
			// [XID] // 0x0000000189AFCE10-0x0000000189AFCE30
			public string Log(string seperate) => default; // 0x0000000181490BC0-0x00000001814911C0
		}
	
		// Constructors
		public EffectProfiler() {} // 0x000000018149B2C0-0x000000018149B330
	
		// Methods
		// [XID] // 0x0000000189976ED0-0x0000000189976EF0
		public void OnPlayTimesInputValueChanged(string input) {} // 0x000000018149ADC0-0x000000018149AF10
		// [XID] // 0x000000018997E240-0x000000018997E260
		public void OnInstanceInputValueChanged(string input) {} // 0x000000018149AC70-0x000000018149ADC0
		// [XID] // 0x0000000189985D70-0x0000000189985D90
		public void Start() {} // 0x000000018149B000-0x000000018149B2C0
		// [XID] // 0x000000018998D9C0-0x000000018998D9E0
		public void OnStartButtonClicked() {} // 0x000000018149AF10-0x000000018149B000
		[DebuggerHidden] // 0x0000000189995410-0x0000000189995450
		// [XID] // 0x0000000189995410-0x0000000189995450
		private IEnumerator PlayEffects() => default; // 0x000000018149A400-0x000000018149A510
		// [XID] // 0x000000018999FC70-0x000000018999FC90
		private void SendLog(DateTime startTime, DateTime endTime) {} // 0x000000018149A510-0x000000018149A920
		// [XID] // 0x00000001899A7900-0x00000001899A7920
		private void WriteFile(DateTime startTime, DateTime endTime) {} // 0x000000018149A920-0x000000018149AC70
	}
}
