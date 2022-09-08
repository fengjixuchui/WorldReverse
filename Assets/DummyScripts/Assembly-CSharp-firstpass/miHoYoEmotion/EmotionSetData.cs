/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	[Serializable]
	[CreateAssetMenu] // 0x0000000189BD8950-0x0000000189BD89A0
	public class EmotionSetData : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 8510
	{
		// Fields
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public string[] phonemeSet; // 0x18
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public string[] emotionSet; // 0x20
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public string[] eyeCtrlSet; // 0x28
	
		// Constructors
		public EmotionSetData() {} // 0x000000018732F970-0x000000018732F9E0
	
		// Methods
		// [XID] // 0x0000000189697520-0x0000000189697540
		public string PhonemeName(int index) => default; // 0x000000018732F890-0x000000018732F970
		// [XID] // 0x00000001896898A0-0x00000001896898C0
		public string EmotionName(int index) => default; // 0x000000018732F530-0x000000018732F610
		// [XID] // 0x000000018960C4A0-0x000000018960C4C0
		public string EyeCtrlName(int index) => default; // 0x000000018732F610-0x000000018732F6F0
		// [XID] // 0x0000000189705DC0-0x0000000189705DE0
		public void OnBeforeSerialize() {} // 0x000000018732F7F0-0x000000018732F890
		// [XID] // 0x000000018961B440-0x000000018961B460
		public void OnAfterDeserialize() {} // 0x000000018732F6F0-0x000000018732F7F0
	}
}
