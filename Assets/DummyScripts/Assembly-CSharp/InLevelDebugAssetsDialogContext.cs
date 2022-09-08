/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugAssetsDialogContext : BaseDialogContext // TypeDefIndex: 28640
{
	// Fields
	private const char NEWLINE = '\x000a'; // Metadata: 0x00B0DA6F
	private const string SIMULATION_MODE_TEXT = "Simulation Mode."; // Metadata: 0x00B0DA71
	private const string LAYOUT_GROUP_PATH = "Scroll View/Viewport/LayoutGroup"; // Metadata: 0x00B0DA85
	private const string TEXT_BERIFING_PATH = "Scroll View/Viewport/LayoutGroup/Briefing"; // Metadata: 0x00B0DAA9
	private const string BUTTON_REFRESH_PATH = "ButtonRefresh"; // Metadata: 0x00B0DAD6
	private const string BUTTON_CLOSE_PATH = "ButtonClose"; // Metadata: 0x00B0DAE7
	private const string TOGGLE_DETAIL_PATH = "ToggleDetail"; // Metadata: 0x00B0DAF6
	private UnityEngine.UI.Text _textBriefing; // 0x178
	private Button _buttonRefresh; // 0x180
	private Button _buttonClose; // 0x188
	private Toggle _toggleDetail; // 0x190
	private LayoutGroup _layoutGroup; // 0x198
	private TextItemBreeder _breeder; // 0x1A0
	private bool _detailed; // 0x1A8

	// Nested types
	private class TextItemBreeder // TypeDefIndex: 28641
	{
		// Fields
		private readonly Queue<UnityEngine.UI.Text> _reserved; // 0x10
		private readonly List<UnityEngine.UI.Text> _inUse; // 0x18
		private readonly StringBuilder _builder; // 0x20
		private readonly UnityEngine.UI.Text _prototype; // 0x28

		// Constructors
		public TextItemBreeder() {} // Dummy constructor
		public TextItemBreeder(UnityEngine.UI.Text prototype) {} // 0x0000000183A4C350-0x0000000183A4C490

		// Methods
		// [XID] // 0x0000000189A31640-0x0000000189A31660
		public void Clear() {} // 0x0000000183A4AD70-0x0000000183A4AF00
		// [XID] // 0x0000000189A39110-0x0000000189A39130
		public TextItemBreeder Begin() => default; // 0x0000000183A4B2A0-0x0000000183A4B360
		// [IDTag] // 0x0000000189A408F0-0x0000000189A40930
		// [XID] // 0x0000000189A408F0-0x0000000189A40930
		public TextItemBreeder Append(char value, int repeatCount) => default; // 0x0000000183A4B840-0x0000000183A4B920
		// [IDTag] // 0x0000000189A4AF70-0x0000000189A4AFB0
		// [XID] // 0x0000000189A4AF70-0x0000000189A4AFB0
		public TextItemBreeder Append(char value) => default; // 0x0000000183A4C0D0-0x0000000183A4C1A0
		// [IDTag] // 0x0000000189A55790-0x0000000189A557D0
		// [XID] // 0x0000000189A55790-0x0000000189A557D0
		public TextItemBreeder Append(ulong value) => default; // 0x0000000183A4B500-0x0000000183A4B5D0
		// [IDTag] // 0x0000000189A600C0-0x0000000189A60100
		// [XID] // 0x0000000189A600C0-0x0000000189A60100
		public TextItemBreeder Append(uint value) => default; // 0x0000000183A4B430-0x0000000183A4B500
		// [IDTag] // 0x0000000189A6ABA0-0x0000000189A6ABE0
		// [XID] // 0x0000000189A6ABA0-0x0000000189A6ABE0
		public TextItemBreeder Append(ushort value) => default; // 0x0000000183A4B5D0-0x0000000183A4B6A0
		// [IDTag] // 0x0000000189A74EF0-0x0000000189A74F30
		// [XID] // 0x0000000189A74EF0-0x0000000189A74F30
		public TextItemBreeder Append(float value) => default; // 0x0000000183A4B920-0x0000000183A4B9F0
		// [IDTag] // 0x0000000189A7F920-0x0000000189A7F960
		// [XID] // 0x0000000189A7F920-0x0000000189A7F960
		public TextItemBreeder Append(sbyte value) => default; // 0x0000000183A4BE60-0x0000000183A4BF30
		// [IDTag] // 0x0000000189A8A530-0x0000000189A8A570
		// [XID] // 0x0000000189A8A530-0x0000000189A8A570
		public TextItemBreeder Append(object value) => default; // 0x0000000183A4BF30-0x0000000183A4C000
		// [IDTag] // 0x0000000189A949E0-0x0000000189A94A20
		// [XID] // 0x0000000189A949E0-0x0000000189A94A20
		public TextItemBreeder Append(long value) => default; // 0x0000000183A4BC90-0x0000000183A4BD60
		// [IDTag] // 0x0000000189A9F110-0x0000000189A9F150
		// [XID] // 0x0000000189A9F110-0x0000000189A9F150
		public TextItemBreeder Append(int value) => default; // 0x0000000183A4C1A0-0x0000000183A4C270
		// [IDTag] // 0x0000000189AA95D0-0x0000000189AA9610
		// [XID] // 0x0000000189AA95D0-0x0000000189AA9610
		public TextItemBreeder Append(short value) => default; // 0x0000000183A4C000-0x0000000183A4C0D0
		// [IDTag] // 0x0000000189AB42F0-0x0000000189AB4330
		// [XID] // 0x0000000189AB42F0-0x0000000189AB4330
		public TextItemBreeder Append(double value) => default; // 0x0000000183A4B360-0x0000000183A4B430
		// [IDTag] // 0x0000000189ABEC20-0x0000000189ABEC60
		// [XID] // 0x0000000189ABEC20-0x0000000189ABEC60
		public TextItemBreeder Append(decimal value) => default; // 0x0000000183A4C270-0x0000000183A4C350
		// [IDTag] // 0x0000000189AC9490-0x0000000189AC94D0
		// [XID] // 0x0000000189AC9490-0x0000000189AC94D0
		public TextItemBreeder Append(byte value) => default; // 0x0000000183A4B770-0x0000000183A4B840
		// [IDTag] // 0x0000000189AD4040-0x0000000189AD4080
		// [XID] // 0x0000000189AD4040-0x0000000189AD4080
		public TextItemBreeder Append(bool value) => default; // 0x0000000183A4B9F0-0x0000000183A4BAC0
		// [IDTag] // 0x0000000189ADEC50-0x0000000189ADEC90
		// [XID] // 0x0000000189ADEC50-0x0000000189ADEC90
		public TextItemBreeder Append(string value) => default; // 0x0000000183A4B6A0-0x0000000183A4B770
		// [IDTag] // 0x0000000189AE9380-0x0000000189AE93C0
		// [XID] // 0x0000000189AE9380-0x0000000189AE93C0
		public TextItemBreeder Append(char[] value) => default; // 0x0000000183A4BBC0-0x0000000183A4BC90
		// [IDTag] // 0x0000000189AF3DF0-0x0000000189AF3E30
		// [XID] // 0x0000000189AF3DF0-0x0000000189AF3E30
		public TextItemBreeder Append(char[] value, int startIndex, int charCount) => default; // 0x0000000183A4BAC0-0x0000000183A4BBC0
		// [IDTag] // 0x0000000189AFE460-0x0000000189AFE4A0
		// [XID] // 0x0000000189AFE460-0x0000000189AFE4A0
		public TextItemBreeder Append(string value, int startIndex, int count) => default; // 0x0000000183A4BD60-0x0000000183A4BE60
		// [IDTag] // 0x0000000189B08A40-0x0000000189B08A80
		// [XID] // 0x0000000189B08A40-0x0000000189B08A80
		public TextItemBreeder AppendFormat(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000183A4A890-0x0000000183A4A970
		// [IDTag] // 0x0000000189B1A730-0x0000000189B1A770
		// [XID] // 0x0000000189B1A730-0x0000000189B1A770
		public TextItemBreeder AppendFormat(IFormatProvider provider, string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) => default; // 0x0000000183A4AB90-0x0000000183A4AC90
		// [IDTag] // 0x0000000189B2C2C0-0x0000000189B2C300
		// [XID] // 0x0000000189B2C2C0-0x0000000189B2C300
		public TextItemBreeder AppendFormat(string format, object arg0) => default; // 0x0000000183A4AC90-0x0000000183A4AD70
		// [IDTag] // 0x0000000189B36770-0x0000000189B367B0
		// [XID] // 0x0000000189B36770-0x0000000189B367B0
		public TextItemBreeder AppendFormat(string format, object arg0, object arg1) => default; // 0x0000000183A4AA90-0x0000000183A4AB90
		// [IDTag] // 0x0000000189B411D0-0x0000000189B41210
		// [XID] // 0x0000000189B411D0-0x0000000189B41210
		public TextItemBreeder AppendFormat(string format, object arg0, object arg1, object arg2) => default; // 0x0000000183A4A970-0x0000000183A4AA90
		// [XID] // 0x0000000189B4BA60-0x0000000189B4BA80
		public TextItemBreeder AppendLine() => default; // 0x0000000183A4B1E0-0x0000000183A4B2A0
		// [XID] // 0x0000000189B53010-0x0000000189B53030
		public void End() {} // 0x0000000183A4AF00-0x0000000183A4B1E0
	}

	// Constructors
	public InLevelDebugAssetsDialogContext() {} // 0x0000000183A58B40-0x0000000183A58BF0

	// Methods
	// [XID] // 0x00000001899F3850-0x00000001899F3870
	public override void SetupView() {} // 0x0000000183A588A0-0x0000000183A58B40
	// [XID] // 0x00000001899FB190-0x00000001899FB1B0
	private void OnClickButtonRefresh() {} // 0x0000000183A57B60-0x0000000183A57C00
	// [XID] // 0x0000000189A023C0-0x0000000189A023E0
	private void OnClickButtonClose() {} // 0x0000000183A57C00-0x0000000183A57CB0
	// [XID] // 0x0000000189A09BD0-0x0000000189A09BF0
	private void OnToggleDetailedInfo(bool detailed) {} // 0x0000000183A57FD0-0x0000000183A58080
	// [XID] // 0x0000000189A11390-0x0000000189A113B0
	private void RefreshBriefing() {} // 0x0000000183A58080-0x0000000183A588A0
	private T FindControl<T>(string path)
		where T : Component => default;
	// [XID] // 0x0000000189A187A0-0x0000000189A187C0
	private void AddClickCallback(Button button, UnityAction action) {} // 0x0000000183A57EC0-0x0000000183A57FD0
	// [XID] // 0x0000000189A1FE00-0x0000000189A1FE20
	private void AddToggleCallback(Toggle toggle, UnityAction<bool> action) {} // 0x0000000183A57DB0-0x0000000183A57EC0
}

