/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public abstract class BaseEmoAnimation // TypeDefIndex: 8463
	{
		// Fields
		protected ElementManager _manager; // 0x10
		protected List<EmoTrack> _trackList; // 0x18
	
		// Properties
		public ElementManager manager { /* [XID] */ /* 0x0000000189825580-0x00000001898255A0 */ get; } // 0x0000000187317EB0-0x0000000187317F50 
	
		// Constructors
		protected BaseEmoAnimation() {} // 0x0000000187317E10-0x0000000187317EB0
	
		// Methods
		// [XID] // 0x0000000189ADCDB0-0x0000000189ADCDD0
		protected void AddTrack(int trackIndex, EmoTrack track) {} // 0x00000001873166E0-0x0000000187316830
		// [XID] // 0x0000000189AF37A0-0x0000000189AF37C0
		protected EmoTrack GetTrack(int trackIndex) => default; // 0x0000000187316FB0-0x00000001873170A0
		// [XID] // 0x0000000189AFB000-0x0000000189AFB020
		public virtual void Init(ElementManager manager) {} // 0x00000001873170A0-0x0000000187317150
		// [XID] // 0x0000000189B025E0-0x0000000189B02600
		public void Update(float deltaTime) {} // 0x0000000187317CE0-0x0000000187317E10
		// [XID] // 0x0000000189B09BA0-0x0000000189B09BC0
		public void Apply() {} // 0x0000000187316930-0x0000000187316A50
		// [XID] // 0x0000000189B11660-0x0000000189B11680
		public void RegisterFinishHandler(EmoTrack.EmoVoidHandler handler, int trackIndex = 0 /* Metadata: 0x00ADF7B8 */) {} // 0x0000000187317650-0x0000000187317740
		// [XID] // 0x0000000189859410-0x0000000189859430
		public void UnregisterFinishHandler(EmoTrack.EmoVoidHandler handler, int trackIndex = 0 /* Metadata: 0x00ADF7BC */) {} // 0x0000000187317BF0-0x0000000187317CE0
		// [XID] // 0x0000000189860490-0x00000001898604B0
		public void CallFinishHandler(int trackIndex) {} // 0x0000000187316B70-0x0000000187316C40
		// [XID] // 0x0000000189867B30-0x0000000189867B50
		public void CallAllFinishHandler() {} // 0x0000000187316A50-0x0000000187316B70
		// [XID] // 0x0000000189B35F50-0x0000000189B35F70
		public BaseShape GetCurShape(int trackIndex) => default; // 0x0000000187316EE0-0x0000000187316FB0
		// [XID] // 0x00000001898766B0-0x00000001898766D0
		public void SetCurShape(BaseShape shape, int trackIndex = 0 /* Metadata: 0x00ADF7C0 */) {} // 0x0000000187317740-0x0000000187317830
		// [XID] // 0x000000018987E3B0-0x000000018987E3D0
		public void EnableShape(BaseShape shape, float startTime = 0f /* Metadata: 0x00ADF7C4 */, int trackIndex = 0 /* Metadata: 0x00ADF7C8 */) {} // 0x0000000187316DE0-0x0000000187316EE0
		// [XID] // 0x0000000189B4CA90-0x0000000189B4CAB0
		public void PlayDefault(BaseShape shape, int trackIndex = 0 /* Metadata: 0x00ADF7CC */, string postToPlay = "Normal" /* Metadata: 0x00ADF7D0 */) {} // 0x0000000187317550-0x0000000187317650
		// [XID] // 0x000000018988C9B0-0x000000018988C9D0
		public void ApendShape(BaseShape shape, float startTime = 0f /* Metadata: 0x00ADF7DA */, int trackIndex = 0 /* Metadata: 0x00ADF7DE */) {} // 0x0000000187316830-0x0000000187316930
		// [XID] // 0x0000000189B541E0-0x0000000189B54200
		public void ClearShape(int trackIndex = 0 /* Metadata: 0x00ADF7E2 */) {} // 0x0000000187316D10-0x0000000187316DE0
		// [XID] // 0x000000018989B5D0-0x000000018989B5F0
		public void ClearShapeOnly(int trackIndex = 0 /* Metadata: 0x00ADF7E6 */) {} // 0x0000000187316C40-0x0000000187316D10
		// [XID] // 0x0000000189B72200-0x0000000189B72220
		public void PlayBakedSequenceAtTrack(SequenceBakeData.BakeData bakeData, int trackIndex) {} // 0x0000000187317230-0x0000000187317320
		// [XID] // 0x00000001898A9FC0-0x00000001898A9FE0
		public bool IsTrackPlaying(int trackIndex) => default; // 0x0000000187317150-0x0000000187317230
		// [XID] // 0x0000000189B80990-0x0000000189B809B0
		public virtual void PlayBakedSequence(SequenceBakeData bakeData) {} // 0x0000000187317450-0x0000000187317550
		// [XID] // 0x00000001898B9480-0x00000001898B94A0
		public virtual void PlayBakedSequenceExcept(SequenceBakeData bakeData, int track) {} // 0x0000000187317320-0x0000000187317450
		// [XID] // 0x0000000189BACE20-0x0000000189BACE40
		public void TogglePauseEmo(bool toggle) {} // 0x0000000187317AE0-0x0000000187317BF0
		// [XID] // 0x0000000189BD2910-0x0000000189BD2930
		public void ToggleEyeCtrl(bool toggle) {} // 0x0000000187317920-0x0000000187317A10
		// [XID] // 0x0000000189BD9E70-0x0000000189BD9E90
		public void TogglePauseBlink(bool toggle) {} // 0x0000000187317A10-0x0000000187317AE0
		// [XID] // 0x0000000189BCB360-0x0000000189BCB380
		public void StopSequence() {} // 0x0000000187317830-0x0000000187317920
	}
}
