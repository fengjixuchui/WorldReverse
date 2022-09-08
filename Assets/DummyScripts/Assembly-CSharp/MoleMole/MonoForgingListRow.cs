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
	public class MonoForgingListRow : MonoSpriteProxy // TypeDefIndex: 30773
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _itemIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cornerIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _lockIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockRoot; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _doingText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _finishText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _receiveText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _noItemText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _descRoot; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _progressRoot; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _colorRoot; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _nameCanvas; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _descCanvas; // 0xA8
	
		// Properties
		public Button actionBtn { /* [XID] */ /* 0x0000000189A2FE50-0x0000000189A2FE70 */ get => default; } // 0x0000000184AE4A50-0x0000000184AE4AF0 
		public bool showNewIcon { /* [XID] */ /* 0x0000000189A37820-0x0000000189A37840 */ set {} } // 0x0000000184AE4AF0-0x0000000184AE4BE0
	
		// Nested types
		public enum Mode // TypeDefIndex: 30774
		{
			Forge = 0,
			FurnitureBuild = 1
		}
	
		// Constructors
		public MonoForgingListRow() {} // 0x0000000184AE4990-0x0000000184AE4A50
	
		// Methods
		// [XID] // 0x0000000189A3EF70-0x0000000189A3EF90
		public void SetForgingListRow(uint forgeId) {} // 0x0000000184AE3DC0-0x0000000184AE43D0
		// [XID] // 0x0000000189A465F0-0x0000000189A46610
		public void SetQueueItemRowForging(uint forgeId, uint finishNum, uint unfinishNum) {} // 0x0000000184AE43D0-0x0000000184AE44D0
		// [XID] // 0x0000000189A4DDE0-0x0000000189A4DE00
		public void SetQueueItemRowFurnitureMake(uint makeId, bool isFinish) {} // 0x0000000184AE44D0-0x0000000184AE45E0
		// [XID] // 0x0000000189A555F0-0x0000000189A55610
		private void SetQueueItemRow(uint showItemId, uint finishNum, uint unfinishNum, Mode mode) {} // 0x0000000184AE3930-0x0000000184AE3DC0
		// [XID] // 0x0000000189A5CEF0-0x0000000189A5CF10
		public void SetQueueNoItemRow(uint unlockLevel, Mode mode) {} // 0x0000000184AE45E0-0x0000000184AE4990
	}
}
