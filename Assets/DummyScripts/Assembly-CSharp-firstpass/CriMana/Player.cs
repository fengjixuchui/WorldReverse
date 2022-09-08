/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using CriMana.Detail;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CriMana
{
	public class Player : CriDisposable // TypeDefIndex: 7176
	{
		// Fields
		private const int InvalidPlayerId = -1; // Metadata: 0x00ADE64F
		private static Player updatingPlayer; // 0x00
		private int playerId; // 0x20
		private bool isDisposed; // 0x24
		private Status internalrequiredStatus; // 0x28
		private Status nativeStatus; // 0x2C
		private Status? lastNativeStatus; // 0x30
		private Status? lastPlayerStatus; // 0x38
		private bool wasStopping; // 0x40
		private bool isPreparingForRendering; // 0x41
		private bool isNativeStartInvoked; // 0x42
		private bool isNativeInitialized; // 0x43
		private RendererResource rendererResource; // 0x48
		private MovieInfo _movieInfo; // 0x50
		private FrameInfo _frameInfo; // 0x58
		private bool isMovieInfoAvailable; // 0x60
		private bool isFrameInfoAvailable; // 0x61
		private ShaderDispatchCallback _shaderDispatchCallback; // 0x68
		private bool enableSubtitle; // 0x70
		private int subtitleBufferSize; // 0x74
		private uint droppedFrameCount; // 0x78
		private CriAtomExPlayer _atomExPlayer; // 0x80
		private CriAtomEx3dSource _atomEx3Dsource; // 0x88
		private TimerType _timerType; // 0x90
		private bool isStoppingForSeek; // 0x94
		public CuePointCallback cuePointCallback; // 0x98
		public StatusChangeCallback statusChangeCallback; // 0xA0
	
		// Properties
		private Status requiredStatus { /* [XID] */ /* 0x00000001897156B0-0x00000001897156D0 */ get => default; /* [XID] */ /* 0x00000001899B7340-0x00000001899B7360 */ set {} } // 0x0000000187A444F0-0x0000000187A44590 0x0000000187A44B40-0x0000000187A44C10
		public bool additiveMode { /* [XID] */ /* 0x00000001899CDDB0-0x00000001899CDDF0 */ get; set; } // 0x0000000187A43E90-0x0000000187A43EF0 0x0000000187A44980-0x0000000187A449F0
		public int maxFrameDrop { /* [XID] */ /* 0x00000001899DF9A0-0x00000001899DF9E0 */ get; set; } // 0x0000000187A442B0-0x0000000187A44310 0x0000000187A44A60-0x0000000187A44AD0
		public bool applyTargetAlpha { /* [XID] */ /* 0x00000001899F17B0-0x00000001899F17F0 */ get; set; } // 0x0000000187A43EF0-0x0000000187A43F50 0x0000000187A449F0-0x0000000187A44A60
		public bool uiRenderMode { /* [XID] */ /* 0x0000000189A038D0-0x0000000189A03910 */ get; set; } // 0x0000000187A44800-0x0000000187A44860 0x0000000187A44CF0-0x0000000187A44D60
		public bool isFrameAvailable { /* [XID] */ /* 0x0000000189A15530-0x0000000189A15550 */ get => default; } // 0x0000000187A44210-0x0000000187A442B0 
		public MovieInfo movieInfo { /* [XID] */ /* 0x000000018984ECA0-0x000000018984ECC0 */ get => default; } // 0x0000000187A44310-0x0000000187A443C0 
		public FrameInfo frameInfo { /* [XID] */ /* 0x0000000189A24050-0x0000000189A24070 */ get => default; } // 0x0000000187A440B0-0x0000000187A44160 
		public Status status { /* [XID] */ /* 0x0000000189A2B390-0x0000000189A2B3B0 */ get => default; } // 0x0000000187A44590-0x0000000187A446A0 
		public int numberOfEntries { /* [XID] */ /* 0x0000000189A329D0-0x0000000189A329F0 */ get => default; } // 0x0000000187A443C0-0x0000000187A44490 
		public IntPtr subtitleBuffer { /* [XID] */ /* 0x0000000189A3A390-0x0000000189A3A3D0 */ get; /* [XID] */ /* 0x0000000189A44B60-0x0000000189A44BA0 */ private set; } // 0x0000000187A446A0-0x0000000187A44700 0x0000000187A44C10-0x0000000187A44C80
		public int subtitleSize { get; /* [XID] */ /* 0x0000000189A56940-0x0000000189A56980 */ private set; } // 0x0000000187A44700-0x0000000187A44760 0x0000000187A44C80-0x0000000187A44CF0
		public CriAtomExPlayer atomExPlayer { /* [XID] */ /* 0x0000000189A611B0-0x0000000189A611D0 */ get => default; } // 0x0000000187A44000-0x0000000187A440B0 
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics { /* [XID] */ /* 0x000000018969E120-0x000000018969E140 */ get => default; } // 0x0000000187A43F50-0x0000000187A44000 
		public TimerType timerType { /* [XID] */ /* 0x0000000189A703D0-0x0000000189A703F0 */ get => default; } // 0x0000000187A44760-0x0000000187A44800 
		public CriManaMoviePlayerHolder playerHolder { /* [XID] */ /* 0x0000000189A77CC0-0x0000000189A77D00 */ get; set; } // 0x0000000187A44490-0x0000000187A444F0 0x0000000187A44AD0-0x0000000187A44B40
		public bool isAlive { /* [XID] */ /* 0x000000018960DF60-0x000000018960DF80 */ get => default; } // 0x0000000187A44160-0x0000000187A44210 
	
		// Events
		public event SubtitleChangeCallback OnSubtitleChanged;
	
		// Nested types
		public enum Status // TypeDefIndex: 7177
		{
			Stop = 0,
			Dechead = 1,
			WaitPrep = 2,
			Prep = 3,
			Ready = 4,
			Playing = 5,
			PlayEnd = 6,
			Error = 7,
			StopProcessing = 8,
			ReadyForRendering = 9
		}
	
		public enum SetMode // TypeDefIndex: 7178
		{
			New = 0,
			Append = 1,
			AppendRepeatedly = 2
		}
	
		public enum MovieEventSyncMode // TypeDefIndex: 7179
		{
			FrameTime = 0,
			PlayBackTime = 1
		}
	
		public enum AudioTrack // TypeDefIndex: 7180
		{
			Off = 0,
			Auto = 1
		}
	
		public enum TimerType // TypeDefIndex: 7181
		{
			None = 0,
			System = 1,
			Audio = 2,
			User = 3,
			Manual = 4
		}
	
		public delegate void CuePointCallback(ref EventPoint eventPoint); // TypeDefIndex: 7182; 0x0000000187A39180-0x0000000187A39310
	
		public delegate void StatusChangeCallback(Status status); // TypeDefIndex: 7183; 0x0000000187A4C210-0x0000000187A4C3A0
	
		public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer); // TypeDefIndex: 7184; 0x0000000187A4C530-0x0000000187A4C6C0
	
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode); // TypeDefIndex: 7185; 0x0000000187A4BDC0-0x0000000187A4C080
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // TypeDefIndex: 7186; 0x0000000187A38DE0-0x0000000187A38FC0
	
		public enum CriManaUnityPlayer_RenderEventAction // TypeDefIndex: 7187
		{
			UPDATE = 0,
			INITIALIZE = 256,
			RENDER = 512,
			DESTROY = 768
		}
	
		// Constructors
		public Player() {} // 0x0000000187A43610-0x0000000187A438B0
		public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length) {} // 0x0000000187A438B0-0x0000000187A43C90
		static Player() {} // 0x0000000187A435B0-0x0000000187A43610
	
		// Methods
		~Player() {} // 0x0000000187A3F680-0x0000000187A3F730
		// [IDTag] // 0x0000000189A89F60-0x0000000189A89FA0
		// [XID] // 0x0000000189A89F60-0x0000000189A89FA0
		public override void Dispose() {} // 0x0000000187A3F2C0-0x0000000187A3F370
		// [XID] // 0x000000018975B950-0x000000018975B970
		public void CreateRendererResource(int width, int height, bool alpha) {} // 0x0000000187A3EA70-0x0000000187A3EDA0
		// [XID] // 0x0000000189A9BE50-0x0000000189A9BE70
		public void DisposeRendererResource() {} // 0x0000000187A3F210-0x0000000187A3F2C0
		// [XID] // 0x0000000189AA3400-0x0000000189AA3420
		public void Prepare() {} // 0x0000000187A40AD0-0x0000000187A40C30
		// [XID] // 0x0000000189AAA880-0x0000000189AAA8A0
		public void PrepareForRendering() {} // 0x0000000187A40700-0x0000000187A40920
		// [XID] // 0x0000000189B5EC80-0x0000000189B5ECA0
		public void Start() {} // 0x0000000187A429D0-0x0000000187A42C10
		// [XID] // 0x0000000189AB9B80-0x0000000189AB9BA0
		public void Stop() {} // 0x0000000187A42D70-0x0000000187A42E70
		// [XID] // 0x0000000189AC1720-0x0000000189AC1740
		public void StopForSeek() {} // 0x0000000187A42C10-0x0000000187A42D70
		// [XID] // 0x0000000189AC8EC0-0x0000000189AC8EE0
		public void Pause(bool sw) {} // 0x0000000187A405F0-0x0000000187A40700
		// [XID] // 0x0000000189AD0620-0x0000000189AD0640
		public bool IsPaused() => default; // 0x0000000187A400C0-0x0000000187A40190
		// [XID] // 0x0000000189BC6650-0x0000000189BC6670
		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x00ADE63A */) => default; // 0x0000000187A41AA0-0x0000000187A41CD0
		// [IDTag] // 0x0000000189AE0140-0x0000000189AE0180
		// [XID] // 0x0000000189AE0140-0x0000000189AE0180
		public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New /* Metadata: 0x00ADE63E */) => default; // 0x0000000187A412A0-0x0000000187A413F0
		// [IDTag] // 0x0000000189AEA780-0x0000000189AEA7F0
		[Obsolete] // 0x0000000189AEA780-0x0000000189AEA7F0
		// [XID] // 0x0000000189AEA780-0x0000000189AEA7F0
		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New /* Metadata: 0x00ADE642 */) => default; // 0x0000000187A413F0-0x0000000187A41540
		// [XID] // 0x0000000189763380-0x00000001897633A0
		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New /* Metadata: 0x00ADE646 */) => default; // 0x0000000187A410F0-0x0000000187A412A0
		// [XID] // 0x0000000189B00E60-0x0000000189B00E80
		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New /* Metadata: 0x00ADE64A */) => default; // 0x0000000187A41920-0x0000000187A41AA0
		// [XID] // 0x0000000189B8AF40-0x0000000189B8AF60
		public void Loop(bool sw) {} // 0x0000000187A40420-0x0000000187A40510
		// [XID] // 0x0000000189BBE990-0x0000000189BBE9B0
		public void SetMasterTimerType(TimerType timerType) {} // 0x0000000187A41E00-0x0000000187A41EE0
		// [XID] // 0x000000018974D110-0x000000018974D130
		public void SetSeekPosition(int frameNumber) {} // 0x0000000187A42180-0x0000000187A42260
		// [XID] // 0x0000000189B1E7F0-0x0000000189B1E810
		public void SetMovieEventSyncMode(MovieEventSyncMode mode) {} // 0x0000000187A420A0-0x0000000187A42180
		// [XID] // 0x0000000189B26180-0x0000000189B261A0
		public void SetSpeed(float speed) {} // 0x0000000187A42310-0x0000000187A423F0
		// [XID] // 0x00000001898343C0-0x00000001898343E0
		public void SetMaxPictureDataSize(uint maxDataSize) {} // 0x0000000187A41EE0-0x0000000187A41FC0
		// [XID] // 0x0000000189B34910-0x0000000189B34930
		public void SetBufferingTime(float sec) {} // 0x0000000187A40F10-0x0000000187A40FF0
		// [XID] // 0x000000018979C5F0-0x000000018979C610
		public void SetMinBufferSize(int min_buffer_size) {} // 0x0000000187A41FC0-0x0000000187A420A0
		// [IDTag] // 0x0000000189B43DB0-0x0000000189B43DF0
		// [XID] // 0x0000000189B43DB0-0x0000000189B43DF0
		public void SetAudioTrack(int track) {} // 0x0000000187A40D10-0x0000000187A40DF0
		// [IDTag] // 0x0000000189B4E610-0x0000000189B4E650
		// [XID] // 0x0000000189B4E610-0x0000000189B4E650
		public void SetAudioTrack(AudioTrack track) {} // 0x0000000187A40DF0-0x0000000187A40F10
		// [IDTag] // 0x0000000189B59000-0x0000000189B59040
		// [XID] // 0x0000000189B59000-0x0000000189B59040
		public void SetSubAudioTrack(int track) {} // 0x0000000187A42610-0x0000000187A426F0
		// [IDTag] // 0x0000000189B63470-0x0000000189B634B0
		// [XID] // 0x0000000189B63470-0x0000000189B634B0
		public void SetSubAudioTrack(AudioTrack track) {} // 0x0000000187A424F0-0x0000000187A42610
		// [IDTag] // 0x0000000189B6DA50-0x0000000189B6DA90
		// [XID] // 0x0000000189B6DA50-0x0000000189B6DA90
		public void SetExtraAudioTrack(int track) {} // 0x0000000187A41760-0x0000000187A41840
		// [IDTag] // 0x0000000189B780B0-0x0000000189B780F0
		// [XID] // 0x0000000189B780B0-0x0000000189B780F0
		public void SetExtraAudioTrack(AudioTrack track) {} // 0x0000000187A41640-0x0000000187A41760
		// [XID] // 0x0000000189B82900-0x0000000189B82920
		public void SetVolume(float volume) {} // 0x0000000187A428F0-0x0000000187A429D0
		// [XID] // 0x0000000189B89FE0-0x0000000189B8A000
		public void SetSubAudioVolume(float volume) {} // 0x0000000187A426F0-0x0000000187A427D0
		// [XID] // 0x0000000189BAFC00-0x0000000189BAFC20
		public void SetExtraAudioVolume(float volume) {} // 0x0000000187A41840-0x0000000187A41920
		// [XID] // 0x0000000189B98910-0x0000000189B98930
		public void SetBusSendLevel(string bus_name, float level) {} // 0x0000000187A40FF0-0x0000000187A410F0
		// [XID] // 0x0000000189B9FDA0-0x0000000189B9FDC0
		public void SetSubAudioBusSendLevel(string bus_name, float volume) {} // 0x0000000187A423F0-0x0000000187A424F0
		// [XID] // 0x0000000189BA75B0-0x0000000189BA75D0
		public void SetExtraAudioBusSendLevel(string bus_name, float volume) {} // 0x0000000187A41540-0x0000000187A41640
		// [XID] // 0x000000018973AC30-0x000000018973AC50
		public void SetSubtitleChannel(int channel) {} // 0x0000000187A427D0-0x0000000187A428F0
		// [XID] // 0x0000000189BB5FD0-0x0000000189BB5FF0
		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback) {} // 0x0000000187A42260-0x0000000187A42310
		// [XID] // 0x0000000189B276A0-0x0000000189B276C0
		public long GetTime() => default; // 0x0000000187A3F800-0x0000000187A3F8D0
		// [XID] // 0x0000000189BC5340-0x0000000189BC5360
		public int GetDisplayedFrameNo() => default; // 0x0000000187A3F730-0x0000000187A3F800
		// [XID] // 0x0000000189BCCDA0-0x0000000189BCCDC0
		public bool HasRenderedNewFrame() => default; // 0x0000000187A3F8D0-0x0000000187A3F990
		// [XID] // 0x0000000189BD4480-0x0000000189BD44A0
		public void SetAsrRackId(int asrRackId) {} // 0x0000000187A40C30-0x0000000187A40D10
		// [XID] // 0x0000000189B2E8E0-0x0000000189B2E900
		public void UpdateWithUserTime(ulong timeCount, ulong timeUnit) {} // 0x0000000187A433C0-0x0000000187A43500
		// [XID] // 0x00000001897C2500-0x00000001897C2520
		public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD) {} // 0x0000000187A41CD0-0x0000000187A41E00
		// [XID] // 0x00000001895EFEF0-0x00000001895EFF10
		public void UpdateWithManualTimeAdvanced() {} // 0x0000000187A432B0-0x0000000187A433C0
		// [XID] // 0x00000001895F77F0-0x00000001895F7810
		public void Update() {} // 0x0000000187A43500-0x0000000187A435B0
		// [XID] // 0x00000001899882B0-0x00000001899882D0
		public void OnWillRenderObject(CriManaMovieMaterial sender) {} // 0x0000000187A40510-0x0000000187A405F0
		// [XID] // 0x0000000189947C10-0x0000000189947C30
		public bool UpdateMaterial(UnityEngine.Material material) => default; // 0x0000000187A42E70-0x0000000187A42F70
		// [XID] // 0x0000000189615580-0x00000001896155A0
		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction) {} // 0x0000000187A40190-0x0000000187A402B0
		// [IDTag] // 0x000000018961CCE0-0x000000018961CD20
		// [XID] // 0x000000018961CCE0-0x000000018961CD20
		private void Dispose(bool disposing) {} // 0x0000000187A3F370-0x0000000187A3F680
		// [XID] // 0x0000000189B72260-0x0000000189B72280
		private void InternalUpdate() {} // 0x0000000187A3F990-0x0000000187A3FF60
		[DebuggerHidden] // 0x000000018962EA30-0x000000018962EA70
		// [XID] // 0x000000018962EA30-0x000000018962EA70
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId) => default; // 0x0000000187A402B0-0x0000000187A40420
		// [XID] // 0x0000000189639610-0x0000000189639630
		private void DisableInfos(bool keepFrameInfo = false /* Metadata: 0x00ADE64E */) {} // 0x0000000187A3F110-0x0000000187A3F210
		// [XID] // 0x0000000189B482F0-0x0000000189B48310
		private void PrepareNativePlayer() {} // 0x0000000187A40920-0x0000000187A40AD0
		// [XID] // 0x0000000189648460-0x0000000189648480
		private void UpdateNativePlayer() {} // 0x0000000187A42F70-0x0000000187A432B0
		// [XID] // 0x000000018964FA90-0x000000018964FAB0
		private void InvokePlayerStatusCheck() {} // 0x0000000187A3FF60-0x0000000187A400C0
		// [XID] // 0x00000001896573A0-0x00000001896573C0
		private void AllocateSubtitleBuffer(int size) {} // 0x0000000187A3B270-0x0000000187A3B480
		// [XID] // 0x000000018978CD60-0x000000018978CD80
		private void DeallocateSubtitleBuffer() {} // 0x0000000187A3EF00-0x0000000187A3F110
		// [MonoPInvokeCallback] // 0x00000001896660C0-0x0000000189666120
		// [XID] // 0x00000001896660C0-0x0000000189666120
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint) {} // 0x0000000187A3EDA0-0x0000000187A3EF00
		private static extern int CRIWAREE87B241D(); // 0x0000000187A3E0D0-0x0000000187A3E1B0
		private static extern int CRIWAREF8EDC953(); // 0x0000000187A3E7A0-0x0000000187A3E880
		private static extern int CRIWAREC5CB2C05(bool useAtomExPlayer, uint maxPathLength); // 0x0000000187A3DCF0-0x0000000187A3DDF0
		private static extern void CRIWAREF4A1A36D(int player_id); // 0x0000000187A3E5E0-0x0000000187A3E6C0
		private static extern void CRIWAREFA3D3598(int player_id, IntPtr binder, string path); // 0x0000000187A3E880-0x0000000187A3E990
		private static extern void CRIWARE6C0CDCDD(int player_id, IntPtr binder, int content_id); // 0x0000000187A3CDF0-0x0000000187A3CEF0
		private static extern void CRIWAREF03B7E5D(int player_id, string path, ulong offset, long range); // 0x0000000187A3E1B0-0x0000000187A3E2D0
		private static extern void CRIWARE097811FC(int player_id, IntPtr data, long datasize); // 0x0000000187A3B7F0-0x0000000187A3B8F0
		private static extern void CRIWARE097811FC(int player_id, byte[] data, long datasize); // 0x0000000187A3B8F0-0x0000000187A3BA00
		private static extern bool CRIWARE1AFA74BE(int player_id, IntPtr binder, string path, bool repeat); // 0x0000000187A3BF10-0x0000000187A3C040
		private static extern bool CRIWARE101AA908(int player_id, IntPtr binder, int content_id, bool repeat); // 0x0000000187A3BE00-0x0000000187A3BF10
		private static extern bool CRIWARE3BF8F4C0(int player_id, string path, ulong offset, long range, bool repeat); // 0x0000000187A3C610-0x0000000187A3C750
		private static extern bool CRIWAREF2C6F5B2(int player_id, IntPtr data, long datasize, bool repeat); // 0x0000000187A3E4D0-0x0000000187A3E5E0
		private static extern bool CRIWAREF2C6F5B2(int player_id, byte[] data, long datasize, bool repeat); // 0x0000000187A3E3B0-0x0000000187A3E4D0
		private static extern void CRIWAREFEC78C5B(int player_id); // 0x0000000187A3E990-0x0000000187A3EA70
		private static extern int CRIWARE3B5030D0(int player_id); // 0x0000000187A3C520-0x0000000187A3C610
		private static extern void CRIWARE7DC649B9(int player_id, CuePointCallbackFromNativeDelegate cbfunc); // 0x0000000187A3D1B0-0x0000000187A3D2B0
		private static extern void CRIWARE026539B7(int player_id, out MovieInfo movie_info); // 0x0000000187A3B570-0x0000000187A3B6F0
		private static extern int CRIWAREC7CB372C(int player_id, IntPtr subtitle_buffer, ref uint subtitle_size); // 0x0000000187A3DDF0-0x0000000187A3DEF0
		private static extern void CRIWARE7DA749B5(int player_id); // 0x0000000187A3D0D0-0x0000000187A3D1B0
		private static extern void CRIWAREBFC0B70E(int player_id); // 0x0000000187A3DC10-0x0000000187A3DCF0
		private static extern void CRIWARE8E3E3566(int player_id); // 0x0000000187A3D570-0x0000000187A3D650
		private static extern void CRIWARE0042EEBC(int player_id, int seek_frame_no); // 0x0000000187A3B480-0x0000000187A3B570
		private static extern void CRIWARE61280D15(int player_id, MovieEventSyncMode mode); // 0x0000000187A3CB20-0x0000000187A3CC10
		private static extern void CRIWARE0AECB3DB(int player_id, int sw); // 0x0000000187A3BB00-0x0000000187A3BBF0
		private static extern bool CRIWARE750622E5(int player_id); // 0x0000000187A3CFE0-0x0000000187A3D0D0
		private static extern void CRIWARE622615F7(int player_id, int sw); // 0x0000000187A3CC10-0x0000000187A3CD00
		private static extern long CRIWARED4E48AB0(int player_id); // 0x0000000187A3DFE0-0x0000000187A3E0D0
		private static extern int CRIWARE6EC0ADF6(int player_id); // 0x0000000187A3CEF0-0x0000000187A3CFE0
		private static extern IntPtr CRIWARE9B209A14(int player_id); // 0x0000000187A3D740-0x0000000187A3D830
		private static extern int CRIWARE8A2E320E(int player_id); // 0x0000000187A3D480-0x0000000187A3D570
		private static extern void CRIWARE2C5AEDDB(int player_id, int track); // 0x0000000187A3C040-0x0000000187A3C130
		private static extern void CRIWARE680FF3BF(int player_id, float vol); // 0x0000000187A3CD00-0x0000000187A3CDF0
		private static extern void CRIWARE3AD4DAE4(int player_id, int track); // 0x0000000187A3C430-0x0000000187A3C520
		private static extern void CRIWARE460F9E59(int player_id, float vol); // 0x0000000187A3C840-0x0000000187A3C930
		private static extern void CRIWAREBDC09776(int player_id, int track); // 0x0000000187A3DB20-0x0000000187A3DC10
		private static extern void CRIWAREAA45197A(int player_id, float vol); // 0x0000000187A3D910-0x0000000187A3DA00
		private static extern void CRIWARE36DAF52C(int player_id, string bus_name, float level); // 0x0000000187A3C220-0x0000000187A3C340
		private static extern void CRIWARE0C1D58F8(int player_id, string bus_name, float level); // 0x0000000187A3BCE0-0x0000000187A3BE00
		private static extern void CRIWAREB5DF052A(int player_id, string bus_name, float level); // 0x0000000187A3DA00-0x0000000187A3DB20
		private static extern void CRIWARE37D35422(int player_id, int channel); // 0x0000000187A3C340-0x0000000187A3C430
		private static extern void CRIWARE307DECC9(int player_id, float speed); // 0x0000000187A3C130-0x0000000187A3C220
		private static extern void CRIWARE4347FC03(int player_id, uint max_data_size); // 0x0000000187A3C750-0x0000000187A3C840
		public static extern void CRIWARED0197067(int player_id, float sec); // 0x0000000187A3DEF0-0x0000000187A3DFE0
		public static extern void CRIWARE0B2034B9(int player_id, int min_buffer_size); // 0x0000000187A3BBF0-0x0000000187A3BCE0
		public static extern void CRIWARE80A15B5F(int player_id, int asr_rack_id); // 0x0000000187A3D390-0x0000000187A3D480
		private static extern void CRIWAREF1D66BBD(int player_id); // 0x0000000187A3E2D0-0x0000000187A3E3B0
		private static extern void CRIWARE944389C0(int player_id, TimerType timer_type); // 0x0000000187A3D650-0x0000000187A3D740
		private static extern void CRIWARE0AAFBE33(int player_id, ulong user_count, ulong user_unit); // 0x0000000187A3BA00-0x0000000187A3BB00
		private static extern void CRIWARE4D02B432(int player_id, ulong timer_unit_n, ulong timer_unit_d); // 0x0000000187A3C930-0x0000000187A3CA30
		private static extern void CRIWAREF7C0025B(int player_id); // 0x0000000187A3E6C0-0x0000000187A3E7A0
		private static extern void CRIWARE7F4598EA(int player_id); // 0x0000000187A3D2B0-0x0000000187A3D390
		private static extern IntPtr CRIWARE086CEF17(int player_id, int bufferSize); // 0x0000000187A3B6F0-0x0000000187A3B7F0
		private static extern bool CRIWARE5097690C(int player_id); // 0x0000000187A3CA30-0x0000000187A3CB20
		private static extern void CRIWAREA7B26B9F(int player_id); // 0x0000000187A3D830-0x0000000187A3D910
		private static extern IntPtr criWareUnity_GetRenderEventFunc(); // 0x0000000187A43DB0-0x0000000187A43E90
	}
}
