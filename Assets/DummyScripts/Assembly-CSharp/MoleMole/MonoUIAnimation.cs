/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x000000018978D220-0x000000018978D270
	public class MonoUIAnimation : MonoBehaviour // TypeDefIndex: 30961
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TimelineAsset _onStart; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TimelineAsset _onEnd; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TimelineAsset[] _customs; // 0x28
		private PlayableDirector _director; // 0x30
		private Action _clearPerformFinishHandler; // 0x38
		private bool _isStarted; // 0x40
		private double _timer; // 0x48
		private double _clipTime; // 0x50
	
		// Constructors
		public MonoUIAnimation() {} // 0x0000000184891A80-0x0000000184891B10
	
		// Methods
		// [XID] // 0x00000001897B0020-0x00000001897B0040
		public void RegisterClearPerformFinishHandler(Action handler) {} // 0x0000000184891820-0x0000000184891900
		// [XID] // 0x00000001897B7D70-0x00000001897B7D90
		public void UnRegisterClearPerformFinishHandler(Action handler) {} // 0x0000000184891900-0x00000001848919E0
		// [XID] // 0x00000001897BFDC0-0x00000001897BFDE0
		private void CheckFinished() {} // 0x00000001848912E0-0x00000001848913D0
		// [XID] // 0x00000001897C76A0-0x00000001897C76C0
		private void Awake() {} // 0x0000000184891230-0x00000001848912E0
		// [XID] // 0x00000001897CE980-0x00000001897CE9A0
		private void Update() {} // 0x00000001848919E0-0x0000000184891A80
		// [XID] // 0x00000001897D6120-0x00000001897D6140
		public bool PlayStart(DirectorWrapMode mode = DirectorWrapMode.Hold /* Metadata: 0x00B11AEA */) => default; // 0x0000000184891510-0x0000000184891650
		// [XID] // 0x00000001897DDA00-0x00000001897DDA20
		public bool PlayEnd(DirectorWrapMode mode = DirectorWrapMode.Hold /* Metadata: 0x00B11AEE */) => default; // 0x00000001848913D0-0x0000000184891510
		// [XID] // 0x00000001897E52F0-0x00000001897E5310
		public bool Play(int index, DirectorWrapMode mode = DirectorWrapMode.Hold /* Metadata: 0x00B11AF2 */) => default; // 0x0000000184891650-0x0000000184891820
	}
}
