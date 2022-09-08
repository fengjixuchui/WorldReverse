/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DialogMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26147
{
	// Fields
	private ISubtitleViewer _subtitleViewer; // 0x10
	private uint _showingDialogId; // 0x18

	// Nested types
	public interface ISubtitleViewer // TypeDefIndex: 26148
	{
		// Methods
		void Show(uint dialogId);
		void Hide();
	}

	private class RuntimeSubtitleViewer : ISubtitleViewer // TypeDefIndex: 26149
	{
		// Fields
		private SubtitleDialogContext _subtitleDialog; // 0x10

		// Constructors
		public RuntimeSubtitleViewer() {} // 0x0000000181A82FD0-0x0000000181A83060

		// Methods
		// [XID] // 0x000000018983D870-0x000000018983D890
		public void Show(uint dialogId) {} // 0x0000000181A82E60-0x0000000181A82FD0
		// [XID] // 0x00000001898450D0-0x00000001898450F0
		public void Hide() {} // 0x0000000181A82D90-0x0000000181A82E60
	}

	// Constructors
	public DialogMixerBehaviour() {} // 0x0000000181A98B20-0x0000000181A98B90

	// Methods
	// [XID] // 0x0000000189827870-0x0000000189827890
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000181A988A0-0x0000000181A98B20
	// [XID] // 0x000000018982EAC0-0x000000018982EAE0
	public override void OnGraphStart(Playable playable) {} // 0x0000000181A986C0-0x0000000181A987B0
	// [XID] // 0x0000000189836430-0x0000000189836450
	public override void OnGraphStop(Playable playable) {} // 0x0000000181A987B0-0x0000000181A988A0
}

