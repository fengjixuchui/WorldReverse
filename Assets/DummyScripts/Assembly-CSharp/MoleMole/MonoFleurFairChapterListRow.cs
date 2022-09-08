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
	public class MonoFleurFairChapterListRow : MonoUIProxy // TypeDefIndex: 29714
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _fleurFairChapterListRow; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitleMono; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitleDescMono; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _chapterImages; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _effSelected; // 0x60
		private GameObject _effSelectedStateControlNode; // 0x68
	
		// Properties
		public MonoUIContainer effSelected { /* [XID] */ /* 0x00000001897932D0-0x00000001897932F0 */ get => default; } // 0x00000001856333C0-0x0000000185633460 
		public GameObject effSelectedStateControlNode { /* [XID] */ /* 0x000000018979B560-0x000000018979B580 */ get => default; } // 0x0000000185633270-0x00000001856333C0 
		public bool selected { /* [XID] */ /* 0x00000001897C1440-0x00000001897C1460 */ set {} } // 0x0000000185633460-0x0000000185633530
	
		// Constructors
		public MonoFleurFairChapterListRow() {} // 0x00000001856331F0-0x0000000185633270
	
		// Methods
		// [XID] // 0x00000001897A2A00-0x00000001897A2A20
		public Button GetButton() => default; // 0x0000000185632EC0-0x0000000185632F60
		// [XID] // 0x00000001897A9FA0-0x00000001897A9FC0
		public UnityEngine.UI.Text GetTxtTitleMono() => default; // 0x0000000185633000-0x00000001856330A0
		// [XID] // 0x00000001897B19B0-0x00000001897B19D0
		public UnityEngine.UI.Text GetTxtTitleDescMono() => default; // 0x0000000185632F60-0x0000000185633000
		// [XID] // 0x00000001897B93B0-0x00000001897B93D0
		public void SetChapterImage(Action<Image> setAction) {} // 0x00000001856330A0-0x00000001856331F0
	}
}
