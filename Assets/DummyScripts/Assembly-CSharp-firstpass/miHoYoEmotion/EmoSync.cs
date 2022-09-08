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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public class EmoSync : EmoMgrUser // TypeDefIndex: 8484
	{
		// Fields
		public const string DEFAULT_EMOTION = "Default"; // Metadata: 0x00ADF91D
		public const string DEFAULT_EMOTION01 = "Default"; // Metadata: 0x00ADF928
		public const string DEFAULT_PHONEMES = "P_Default"; // Metadata: 0x00ADF933
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string defaultEmotion; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string resetEmotion; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public string resetPhoneme; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private EmotionSetData _setData; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<BaseShape> phonemes; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<BaseShape> emotions; // 0x60
		private Dictionary<string, BaseShape> _phonemeCache; // 0x68
		private Dictionary<string, BaseShape> _emotionCahce; // 0x70
		private string _curEmotion; // 0x78
		private string _preEmotion; // 0x80
		private string _lastEmotion; // 0x88
		private string _curPhoneme; // 0x90
		private string _prePhoneme; // 0x98
		private EmoParamCache _emoParamCache; // 0xA0
		private bool _emotionFromTemplate; // 0xA8
	
		// Properties
		public EmotionSetData setData { /* [XID] */ /* 0x000000018979F7F0-0x000000018979F810 */ get => default; } // 0x000000018732E320-0x000000018732E3C0 
		private string preEmotion { /* [XID] */ /* 0x0000000189A4C920-0x0000000189A4C940 */ get => default; } // 0x000000018732E1C0-0x000000018732E270 
		private string prePhoneme { /* [XID] */ /* 0x00000001897E37F0-0x00000001897E3810 */ get => default; } // 0x000000018732E270-0x000000018732E320 
	
		// Nested types
		public class EmoParamCache // TypeDefIndex: 8485
		{
			// Fields
			public string emotionName; // 0x10
			public string phonemeName; // 0x18
			public float blendTime; // 0x20
			public SequenceBakeData seqData; // 0x28
			private bool _dirty; // 0x30
	
			// Properties
			public bool IsDirty { /* [XID] */ /* 0x00000001898A2AC0-0x00000001898A2AE0 */ get => default; } // 0x000000018732ABA0-0x000000018732AC40 
	
			// Constructors
			public EmoParamCache() {} // 0x000000018732AB20-0x000000018732ABA0
	
			// Methods
			// [XID] // 0x000000018988C990-0x000000018988C9B0
			public void SetEmotionCache(string pEmotionName, float pBlendTime) {} // 0x000000018732A8C0-0x000000018732A990
			// [XID] // 0x0000000189893EE0-0x0000000189893F00
			public void SetPhonemeCache(string pPhoneme, float pBlendTime) {} // 0x000000018732A990-0x000000018732AA60
			// [XID] // 0x00000001897741F0-0x0000000189774210
			public void SetSeqDataCache(SequenceBakeData pSeqData) {} // 0x000000018732AA60-0x000000018732AB20
			// [XID] // 0x00000001899B08D0-0x00000001899B08F0
			private void SetDirty() {} // 0x000000018732A820-0x000000018732A8C0
			// [XID] // 0x00000001898B1930-0x00000001898B1950
			public void Clear() {} // 0x000000018732A770-0x000000018732A820
		}
	
		// Constructors
		public EmoSync() {} // 0x000000018732E050-0x000000018732E1C0
	
		// Methods
		// [XID] // 0x00000001897A6CC0-0x00000001897A6CE0
		public string GetPhonemeNameByIndex(int index) => default; // 0x000000018732B8A0-0x000000018732B970
		// [XID] // 0x00000001896A5B20-0x00000001896A5B40
		public string GetEmotionNameByIndex(int index) => default; // 0x000000018732B6E0-0x000000018732B7B0
		// [XID] // 0x00000001897B65D0-0x00000001897B65F0
		public void UpdatePhonemeCache() {} // 0x000000018732DF10-0x000000018732E050
		// [XID] // 0x0000000189B293E0-0x0000000189B29400
		public void UpdateEmotionCache() {} // 0x000000018732DDD0-0x000000018732DF10
		// [XID] // 0x00000001897C5A50-0x00000001897C5A70
		public void UpdateCache() {} // 0x000000018732DD20-0x000000018732DDD0
		// [XID] // 0x0000000189AA6A30-0x0000000189AA6A50
		public BaseShape GetPhoneme(string name) => default; // 0x000000018732B970-0x000000018732BA60
		// [XID] // 0x00000001897D46F0-0x00000001897D4710
		public BaseShape GetEmotion(string name) => default; // 0x000000018732B7B0-0x000000018732B8A0
		// [XID] // 0x00000001897EB030-0x00000001897EB050
		public void ResetPhoneme(bool playPost = false /* Metadata: 0x00ADF91A */) {} // 0x000000018732C7B0-0x000000018732C910
		// [XID] // 0x00000001897F2D00-0x00000001897F2D20
		public void SetPhoneme(string phonemeName, float blendTime) {} // 0x000000018732D300-0x000000018732D5B0
		// [XID] // 0x000000018977B7C0-0x000000018977B7E0
		public void SetPhonemeAndEmotion(string phonemeName, string emotionName, float blendTime) {} // 0x000000018732CEE0-0x000000018732D300
		// [XID] // 0x0000000189801B80-0x0000000189801BA0
		public void ResetEmotion(bool playPost = false /* Metadata: 0x00ADF91B */) {} // 0x000000018732C640-0x000000018732C7B0
		// [XID] // 0x0000000189809050-0x0000000189809070
		public void SetEmotion(string emotionName, float blendTime) {} // 0x000000018732CC30-0x000000018732CEE0
		// [XID] // 0x0000000189730F00-0x0000000189730F20
		public void SetEmotionOnly(string emotionName) {} // 0x000000018732CAD0-0x000000018732CC30
		// [XID] // 0x00000001896A2C30-0x00000001896A2C50
		public void ClearEmotionFromTemplateState() {} // 0x000000018732B3F0-0x000000018732B490
		// [IDTag] // 0x000000018981F970-0x000000018981F9B0
		// [XID] // 0x000000018981F970-0x000000018981F9B0
		public void PlaySequence(SequenceBakeData seqData, bool playFromTemplate = false /* Metadata: 0x00ADF91C */) {} // 0x000000018732BF90-0x000000018732C310
		// [IDTag] // 0x0000000189829E30-0x0000000189829E70
		// [XID] // 0x0000000189829E30-0x0000000189829E70
		public void PlaySequence(SubSequenceBakeData phonemeData, SubSequenceBakeData emotionData) {} // 0x000000018732C310-0x000000018732C640
		// [XID] // 0x000000018963B230-0x000000018963B250
		public void Toggle(bool toggle) {} // 0x000000018732DB60-0x000000018732DC60
		// [XID] // 0x000000018972C360-0x000000018972C380
		public void ToggleEyeCtrl(bool toggle) {} // 0x000000018732DA80-0x000000018732DB60
		// [XID] // 0x0000000189809960-0x0000000189809980
		public void ClearSequence() {} // 0x000000018732B540-0x000000018732B5E0
		// [XID] // 0x000000018984A550-0x000000018984A570
		public void ClearEmotion() {} // 0x000000018732B490-0x000000018732B540
		// [XID] // 0x000000018961E9E0-0x000000018961EA00
		private void EmoFinish() {} // 0x000000018732B5E0-0x000000018732B6E0
		// [XID] // 0x00000001898593F0-0x0000000189859410
		private void PhoFinish() {} // 0x000000018732BEF0-0x000000018732BF90
		// [XID] // 0x000000018992C140-0x000000018992C160
		private void PerformCache() {} // 0x000000018732BC80-0x000000018732BEF0
		// [XID] // 0x0000000189867B10-0x0000000189867B30
		protected override void Start() {} // 0x000000018732D5B0-0x000000018732DA80
		// [XID] // 0x00000001897AE7B0-0x00000001897AE7D0
		protected void SetDefaultEmotion() {} // 0x000000018732C910-0x000000018732CA10
		// [XID] // 0x0000000189876690-0x00000001898766B0
		protected void SetDefaultPhoneme() {} // 0x000000018732CA10-0x000000018732CAD0
		// [XID] // 0x0000000189765390-0x00000001897653B0
		protected override void OnEnable() {} // 0x000000018732BBC0-0x000000018732BC80
		// [XID] // 0x000000018976CDE0-0x000000018976CE00
		private void OnDestroy() {} // 0x000000018732BA60-0x000000018732BBC0
	}
}
