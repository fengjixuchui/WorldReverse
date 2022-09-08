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
	// [RequireComponent] // 0x0000000189898780-0x00000001898987D0
	public class MonoLocalizedText : MonoBehaviour // TypeDefIndex: 31327
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _textID; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _textPattern; // 0x20
		private UnityEngine.UI.Text _label; // 0x28
		private string _textMapResult; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool _useCustomRegex; // 0x38
	
		// Properties
		public string TextID { /* [XID] */ /* 0x00000001898BAED0-0x00000001898BAEF0 */ get => default; /* [XID] */ /* 0x00000001898C2200-0x00000001898C2220 */ set {} } // 0x000000018427F300-0x000000018427F3A0 0x000000018427F4E0-0x000000018427F590
		public string TextPattern { /* [XID] */ /* 0x00000001898C9CA0-0x00000001898C9CC0 */ get => default; /* [XID] */ /* 0x00000001898D12A0-0x00000001898D12C0 */ set {} } // 0x000000018427F3A0-0x000000018427F440 0x000000018427F590-0x000000018427F640
		public bool UseCustomRegex { /* [XID] */ /* 0x00000001898D8B10-0x00000001898D8B30 */ get => default; /* [XID] */ /* 0x00000001898E07F0-0x00000001898E0810 */ set {} } // 0x000000018427F440-0x000000018427F4E0 0x000000018427F640-0x000000018427F6F0
	
		// Constructors
		public MonoLocalizedText() {} // 0x000000018427F290-0x000000018427F300
	
		// Methods
		// [XID] // 0x00000001898E8320-0x00000001898E8340
		private void Awake() {} // 0x000000018427EA90-0x000000018427EB50
		// [XID] // 0x00000001898EFA60-0x00000001898EFA80
		private void OnEnable() {} // 0x000000018427EE50-0x000000018427EF00
		// [XID] // 0x00000001898F7310-0x00000001898F7330
		private string GetText(string textID, string textPattern) => default; // 0x000000018427ECA0-0x000000018427EE50
		// [IDTag] // 0x00000001898FEA60-0x00000001898FEAA0
		// [XID] // 0x00000001898FEA60-0x00000001898FEAA0
		public void SetupTextID(string textID, string textPattern) {} // 0x000000018427EF00-0x000000018427F050
		// [IDTag] // 0x00000001899093B0-0x00000001899093F0
		// [XID] // 0x00000001899093B0-0x00000001899093F0
		public void SetupTextID(string textID) {} // 0x000000018427F050-0x000000018427F110
		// [XID] // 0x0000000189913BD0-0x0000000189913BF0
		public void Format(params /* 0x000000018989F6F0-0x000000018989F700 */ object[] replaceParams) {} // 0x000000018427EB50-0x000000018427ECA0
		// [IDTag] // 0x0000000189922B80-0x0000000189922BC0
		// [XID] // 0x0000000189922B80-0x0000000189922BC0
		public void SetupTextID(string textID, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] replaceParams) {} // 0x000000018427F110-0x000000018427F290
	}
}
