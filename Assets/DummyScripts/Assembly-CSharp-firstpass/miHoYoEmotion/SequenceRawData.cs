/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	[Serializable]
	[CreateAssetMenu] // 0x0000000189792E40-0x0000000189792E90
	public class SequenceRawData : ScriptableObject // TypeDefIndex: 8529
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public FileType fileType; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public EmotionSetData setData; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public BaseShapeData shapeData; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public EmoSync emoSync; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public PhonemeMarker[] phonemeData; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public EmotionMarker[] emotionData; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public EyeCtrlMarker[] eyeCtrlData; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public RDPhonemeMarker[] newPhonemeData; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float length; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float autoSyncSimp; // 0x5C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool keepLastPhoneme; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public float audioOffset; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public TransitionType emoTransitionType; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public TransitionType phoTransitionType; // 0x6C
	
		// Nested types
		public enum FileType // TypeDefIndex: 8530
		{
			Default = 0,
			Phoneme = 1,
			Emotion = 2
		}
	
		// Constructors
		public SequenceRawData() {} // 0x000000018726B150-0x000000018726B230
	}
}
