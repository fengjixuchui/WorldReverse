/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoFetterVoiceInfo : MonoBehaviour // TypeDefIndex: 30472
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockedIcon; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _voiceTitle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _voiceUnlockInfo; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnAnimator; // 0x30
		private bool _isPlaying; // 0x38
		private bool _unlocked; // 0x39
		private bool _isHighlight; // 0x3A
		private uint _chaConfigID; // 0x3C
		private uint _voiceIndex; // 0x40
		private int currVoiceID; // 0x44
	
		// Constructors
		public MonoFetterVoiceInfo() {} // 0x0000000185632D30-0x0000000185632DB0
	
		// Methods
		// [XID] // 0x0000000189988C00-0x0000000189988C20
		public void Init(FettersExcelConfig config, bool unlocked, uint characterConfigID = 0 /* Metadata: 0x00B1116B */) {} // 0x0000000185632380-0x00000001856326B0
		// [XID] // 0x00000001899903C0-0x00000001899903E0
		private void OnDisable() {} // 0x00000001856327E0-0x0000000185632880
		// [XID] // 0x0000000189997FB0-0x0000000189997FD0
		public void SetHighlight(bool isHighlight) {} // 0x0000000185632A40-0x0000000185632B00
		// [XID] // 0x000000018999F690-0x000000018999F6B0
		private void ClearButtonState() {} // 0x0000000185632250-0x0000000185632380
		// [XID] // 0x00000001899A71D0-0x00000001899A71F0
		private void RefreshButtonState() {} // 0x00000001856326B0-0x00000001856327E0
		// [XID] // 0x00000001899AEB40-0x00000001899AEB60
		public void Play() {} // 0x0000000185632880-0x0000000185632A40
		// [XID] // 0x00000001899B5EC0-0x00000001899B5EE0
		public void TryStop() {} // 0x0000000185632C40-0x0000000185632D30
		// [XID] // 0x00000001899BDBC0-0x00000001899BDBE0
		public void StopCallback(int voiceID) {} // 0x0000000185632B00-0x0000000185632C40
	}
}
