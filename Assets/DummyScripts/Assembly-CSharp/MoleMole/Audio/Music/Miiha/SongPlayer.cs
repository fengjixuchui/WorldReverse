/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Music.Miiha
{
	public class SongPlayer // TypeDefIndex: 11369
	{
		// Fields
		private readonly WorkerThreadContext _context; // 0x10
		private readonly PostEventCallback _postEventCallback; // 0x18
		private uint _playingId; // 0x20
		private bool _pending; // 0x24
	
		// Properties
		public SyncId syncId { /* [XID] */ /* 0x000000018968A740-0x000000018968A780 */ get; /* [XID] */ /* 0x00000001896950A0-0x00000001896950E0 */ set; } // 0x0000000186734470-0x00000001867344E0 0x00000001867346E0-0x0000000186734750
		public ConfigMusic currentMusic { /* [XID] */ /* 0x000000018969F660-0x000000018969F6A0 */ get; /* [XID] */ /* 0x00000001896A9AE0-0x00000001896A9B20 */ private set; } // 0x00000001867342A0-0x0000000186734300 0x00000001867345C0-0x0000000186734620
		public ConfigSong currentSong { /* [XID] */ /* 0x00000001896B3DB0-0x00000001896B3DF0 */ get; /* [XID] */ /* 0x00000001896BDF00-0x00000001896BDF40 */ private set; } // 0x0000000186734300-0x0000000186734360 0x0000000186734620-0x0000000186734680
		public ConfigSong nextSong { /* [XID] */ /* 0x00000001896C8500-0x00000001896C8540 */ get; /* [XID] */ /* 0x00000001896D29B0-0x00000001896D29F0 */ private set; } // 0x0000000186734360-0x00000001867343C0 0x0000000186734680-0x00000001867346E0
		public bool transitioning { /* [XID] */ /* 0x0000000189661860-0x0000000189661880 */ get => default; } // 0x00000001867344E0-0x00000001867345C0 
		public bool playing { /* [XID] */ /* 0x000000018977CA20-0x000000018977CA40 */ get => default; } // 0x00000001867343C0-0x0000000186734470 
	
		// Constructors
		public SongPlayer() {} // Dummy constructor
		public SongPlayer(WorkerThreadContext context) {} // 0x00000001867340A0-0x00000001867342A0
	
		// Methods
		// [XID] // 0x00000001896EBE70-0x00000001896EBE90
		public bool Play(ConfigMusic music, EventCallback eventCallback) => default; // 0x0000000186733460-0x00000001867335C0
		// [XID] // 0x0000000189654230-0x0000000189654250
		public void Stop() {} // 0x0000000186733B90-0x0000000186733CF0
		// [XID] // 0x0000000189678630-0x0000000189678650
		public void Pause() {} // 0x0000000186733330-0x0000000186733460
		// [XID] // 0x00000001897022A0-0x00000001897022C0
		public void Resume() {} // 0x0000000186733A60-0x0000000186733B90
		// [XID] // 0x00000001897099E0-0x0000000189709A00
		public bool SwitchToNextSong(int targetId) => default; // 0x0000000186733CF0-0x00000001867340A0
		// [XID] // 0x00000001897114D0-0x00000001897114F0
		public void FinishTransition() {} // 0x0000000186733140-0x0000000186733330
		// [XID] // 0x00000001897189A0-0x00000001897189C0
		public void AbortTransition() {} // 0x0000000186732E10-0x0000000186733140
		// [IDTag] // 0x00000001897200E0-0x0000000189720120
		// [XID] // 0x00000001897200E0-0x0000000189720120
		private void PostEvent(uint eventId) {} // 0x00000001867336C0-0x0000000186733780
		// [IDTag] // 0x000000018972A4C0-0x000000018972A500
		// [XID] // 0x000000018972A4C0-0x000000018972A500
		private void PostEvent(uint eventId, EventCallback callback, AkCallbackType callbackType, PostEventCallback postCallback) {} // 0x0000000186733780-0x0000000186733A60
		// [XID] // 0x00000001897B1390-0x00000001897B13B0
		private void PostEventCallback(uint eventId, SyncId syncId, uint playingId, uint post) {} // 0x00000001867335C0-0x00000001867336C0
	}
}
