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
	// [RequireComponent] // 0x00000001899005D0-0x0000000189900620
	public class MonoTextOmitPlugin : MonoBehaviour // TypeDefIndex: 30948
	{
		// Fields
		public string textToInstead; // 0x18
		protected const string OMIT_TEXT = ".."; // Metadata: 0x00B11AD8
		protected int _omitTextLength; // 0x20
		protected CharacterInfo _characterInfo; // 0x24
		protected bool _omit; // 0x58
		protected UnityEngine.UI.Text _text; // 0x60
		protected RectTransform _trans; // 0x68
	
		// Constructors
		public MonoTextOmitPlugin() {} // 0x0000000183B69B30-0x0000000183B69BB0
	
		// Methods
		// [XID] // 0x000000018990C480-0x000000018990C4A0
		private void Start() {} // 0x0000000183B69900-0x0000000183B69B30
		// [XID] // 0x0000000189913D70-0x0000000189913D90
		private void OnDestroy() {} // 0x0000000183B697A0-0x0000000183B69900
		// [XID] // 0x000000018991B6E0-0x000000018991B700
		private void OnTextChange() {} // 0x0000000183B69260-0x0000000183B69320
		// [XID] // 0x0000000189922C80-0x0000000189922CA0
		protected virtual void OmitText() {} // 0x0000000183B69320-0x0000000183B695F0
		// [XID] // 0x000000018992A570-0x000000018992A590
		private int getTextLength(string text) => default; // 0x0000000183B695F0-0x0000000183B697A0
	}
}
