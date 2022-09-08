/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public abstract class EmoTrack // TypeDefIndex: 8461
	{
		// Fields
		public const float DEFAULT_POST_TIME = 0.12f; // Metadata: 0x00ADF7A0
		public const float DEFUALT_BLEND_TIME = 0f; // Metadata: 0x00ADF7A4
		public const int TRACK_EMOTION = 0; // Metadata: 0x00ADF7A8
		public const int TRACK_BLINK = 1; // Metadata: 0x00ADF7AC
		public const int TRACK_PHONEME = 2; // Metadata: 0x00ADF7B0
		public const int TRACK_EYECTRL = 3; // Metadata: 0x00ADF7B4
		protected BaseShape _preShape; // 0x10
		protected BaseShape _curShape; // 0x18
		protected string _preTag; // 0x20
		protected string _curTag; // 0x28
		protected float _timeLength; // 0x30
		protected float _timeCnt; // 0x34
		protected bool _isPaused; // 0x38
		protected bool _isTobeFinished; // 0x39
		protected EmoVoidHandler _finishHandler; // 0x40
		protected ElementManager _manager; // 0x48
	
		// Properties
		public bool isPaused { /* [XID] */ /* 0x000000018979E170-0x000000018979E190 */ get; /* [XID] */ /* 0x00000001897A5740-0x00000001897A5760 */ set; } // 0x000000018732EFD0-0x000000018732F070 0x000000018732F070-0x000000018732F120
	
		// Nested types
		public delegate void EmoVoidHandler(); // TypeDefIndex: 8462; 0x000000018732F220-0x000000018732F380
	
		// Constructors
		protected EmoTrack() {} // 0x000000018732EF40-0x000000018732EFD0
	
		// Methods
		// [XID] // 0x00000001897ACD10-0x00000001897ACD30
		public virtual void Init(ElementManager manager) {} // 0x000000018732E8A0-0x000000018732E950
		// [XID] // 0x00000001895E6990-0x00000001895E69B0
		public virtual bool IsPlaying() => default; // 0x000000018732E950-0x000000018732E9F0
		// [XID] // 0x00000001897BC9C0-0x00000001897BC9E0
		public virtual void Update(float deltaTime) {} // 0x000000018732EE90-0x000000018732EF40
		// [XID] // 0x0000000189A20E30-0x0000000189A20E50
		public virtual void Apply() {} // 0x000000018732E480-0x000000018732E520
		// [XID] // 0x0000000189A2F8D0-0x0000000189A2F8F0
		public virtual void RegisterFinishHandler(EmoVoidHandler handler) {} // 0x000000018732EB70-0x000000018732EC50
		// [XID] // 0x00000001897D2E70-0x00000001897D2E90
		public virtual void UnregisterFinishHandler(EmoVoidHandler handler) {} // 0x000000018732EDB0-0x000000018732EE90
		// [XID] // 0x0000000189A64230-0x0000000189A64250
		public virtual void CallFinishHandler() {} // 0x000000018732E520-0x000000018732E5D0
		// [XID] // 0x00000001897E2060-0x00000001897E2080
		public BaseShape GetCurShape() => default; // 0x000000018732E800-0x000000018732E8A0
		// [XID] // 0x0000000189A73360-0x0000000189A73380
		public virtual void SetCurShape(BaseShape shape) {} // 0x000000018732EC50-0x000000018732ED10
		// [XID] // 0x00000001897F1480-0x00000001897F14A0
		public virtual void EnableShape(BaseShape shape, float startTime = 0f /* Metadata: 0x00ADF794 */) {} // 0x000000018732E730-0x000000018732E800
		// [XID] // 0x0000000189A914C0-0x0000000189A914E0
		public virtual void PlayDefault(BaseShape shape, string postToPlay = "" /* Metadata: 0x00ADF798 */) {} // 0x000000018732EAA0-0x000000018732EB70
		// [XID] // 0x00000001898002C0-0x00000001898002E0
		public virtual void ApendShape(BaseShape shape, float startTime = 0f /* Metadata: 0x00ADF79C */) {} // 0x000000018732E3C0-0x000000018732E480
		// [XID] // 0x0000000189807960-0x0000000189807980
		public virtual void ClearShape() {} // 0x000000018732E680-0x000000018732E730
		// [XID] // 0x0000000189AAF1B0-0x0000000189AAF1D0
		public virtual void ClearShapeOnly() {} // 0x000000018732E5D0-0x000000018732E680
		// [XID] // 0x00000001898167E0-0x0000000189816800
		public virtual void PlayBakedSequence(SequenceBakeData.BakeData bakeData) {} // 0x000000018732E9F0-0x000000018732EAA0
		// [XID] // 0x000000018981E0A0-0x000000018981E0C0
		public virtual void StopSequence() {} // 0x000000018732ED10-0x000000018732EDB0
	}
}
