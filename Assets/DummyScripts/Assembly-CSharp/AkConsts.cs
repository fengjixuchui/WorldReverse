/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AkConsts // TypeDefIndex: 11168
{
	// Nested types
	public static class ChannelIndex // TypeDefIndex: 11169
	{
		// Fields
		public const int SetupFrontLeft = 0; // Metadata: 0x00AE8BE6
		public const int SetupFrontRight = 1; // Metadata: 0x00AE8BEA
		public const int SetupCenter = 2; // Metadata: 0x00AE8BEE
		public const int SetupNocenterBackLeft = 2; // Metadata: 0x00AE8BF2
		public const int SetupNocenterBackRight = 3; // Metadata: 0x00AE8BF6
		public const int SetupNocenterSideLeft = 4; // Metadata: 0x00AE8BFA
		public const int SetupNocenterSideRight = 5; // Metadata: 0x00AE8BFE
		public const int SetupWithcenterBackLeft = 3; // Metadata: 0x00AE8C02
		public const int SetupWithcenterBackRight = 4; // Metadata: 0x00AE8C06
		public const int SetupWithcenterSideLeft = 5; // Metadata: 0x00AE8C0A
		public const int SetupWithcenterSideRight = 6; // Metadata: 0x00AE8C0E
		public const int Setup0Lfe = 0; // Metadata: 0x00AE8C12
		public const int Setup1Center = 0; // Metadata: 0x00AE8C16
		public const int Setup1Lfe = 1; // Metadata: 0x00AE8C1A
		public const int Setup2Left = 0; // Metadata: 0x00AE8C1E
		public const int Setup2Right = 1; // Metadata: 0x00AE8C22
		public const int Setup2Lfe = 2; // Metadata: 0x00AE8C26
		public const int Setup3Left = 0; // Metadata: 0x00AE8C2A
		public const int Setup3Right = 1; // Metadata: 0x00AE8C2E
		public const int Setup3Center = 2; // Metadata: 0x00AE8C32
		public const int Setup3Lfe = 3; // Metadata: 0x00AE8C36
		public const int Setup4Frontleft = 0; // Metadata: 0x00AE8C3A
		public const int Setup4Frontright = 1; // Metadata: 0x00AE8C3E
		public const int Setup4Rearleft = 2; // Metadata: 0x00AE8C42
		public const int Setup4Rearright = 3; // Metadata: 0x00AE8C46
		public const int Setup4Lfe = 4; // Metadata: 0x00AE8C4A
		public const int Setup5Frontleft = 0; // Metadata: 0x00AE8C4E
		public const int Setup5Frontright = 1; // Metadata: 0x00AE8C52
		public const int Setup5Center = 2; // Metadata: 0x00AE8C56
		public const int Setup5Rearleft = 3; // Metadata: 0x00AE8C5A
		public const int Setup5Rearright = 4; // Metadata: 0x00AE8C5E
		public const int Setup5Lfe = 5; // Metadata: 0x00AE8C62
		public const int Setup6Frontleft = 0; // Metadata: 0x00AE8C66
		public const int Setup6Frontright = 1; // Metadata: 0x00AE8C6A
		public const int Setup6Rearleft = 2; // Metadata: 0x00AE8C6E
		public const int Setup6Rearright = 3; // Metadata: 0x00AE8C72
		public const int Setup6Sideleft = 4; // Metadata: 0x00AE8C76
		public const int Setup6Sideright = 5; // Metadata: 0x00AE8C7A
		public const int Setup6Lfe = 6; // Metadata: 0x00AE8C7E
		public const int Setup7Frontleft = 0; // Metadata: 0x00AE8C82
		public const int Setup7Frontright = 1; // Metadata: 0x00AE8C86
		public const int Setup7Center = 2; // Metadata: 0x00AE8C8A
		public const int Setup7Rearleft = 3; // Metadata: 0x00AE8C8E
		public const int Setup7Rearright = 4; // Metadata: 0x00AE8C92
		public const int Setup7Sideleft = 5; // Metadata: 0x00AE8C96
		public const int Setup7Sideright = 6; // Metadata: 0x00AE8C9A
		public const int Setup7Lfe = 7; // Metadata: 0x00AE8C9E
	}

	public static class CodecId // TypeDefIndex: 11170
	{
		// Fields
		public const int BANK = 0; // Metadata: 0x00AE8CA2
		public const int PCM = 1; // Metadata: 0x00AE8CA6
		public const int ADPCM = 2; // Metadata: 0x00AE8CAA
		public const int XMA = 3; // Metadata: 0x00AE8CAE
		public const int VORBIS = 4; // Metadata: 0x00AE8CB2
		public const int WIIADPCM = 5; // Metadata: 0x00AE8CB6
		public const int PCMEX = 7; // Metadata: 0x00AE8CBA
		public const int EXTERNAL_SOURCE = 8; // Metadata: 0x00AE8CBE
		public const int XWMA = 9; // Metadata: 0x00AE8CC2
		public const int AAC = 10; // Metadata: 0x00AE8CC6
		public const int FILE_PACKAGE = 11; // Metadata: 0x00AE8CCA
		public const int ATRAC9 = 12; // Metadata: 0x00AE8CCE
		public const int VAG = 13; // Metadata: 0x00AE8CD2
		public const int PROFILERCAPTURE = 14; // Metadata: 0x00AE8CD6
		public const int ANALYSISFILE = 15; // Metadata: 0x00AE8CDA
		public const int MIDI = 16; // Metadata: 0x00AE8CDE
		public const int OPUSNX = 17; // Metadata: 0x00AE8CE2
		public const int CAF = 18; // Metadata: 0x00AE8CE6
		public const int OPUS = 19; // Metadata: 0x00AE8CEA
	}

	public static class CompanyId // TypeDefIndex: 11171
	{
		// Fields
		public const int AUDIOKINETIC_EXTERNAL = 1; // Metadata: 0x00AE8CEE
		public const int MCDSP = 256; // Metadata: 0x00AE8CF2
		public const int WAVEARTS = 257; // Metadata: 0x00AE8CF6
		public const int PHONETICARTS = 258; // Metadata: 0x00AE8CFA
		public const int IZOTOPE = 259; // Metadata: 0x00AE8CFE
		public const int GENAUDIO = 260; // Metadata: 0x00AE8D02
		public const int CRANKCASEAUDIO = 261; // Metadata: 0x00AE8D06
		public const int IOSONO = 262; // Metadata: 0x00AE8D0A
		public const int AUROTECHNOLOGIES = 263; // Metadata: 0x00AE8D0E
		public const int DOLBY = 264; // Metadata: 0x00AE8D12
		public const int TWOBIGEARS = 265; // Metadata: 0x00AE8D16
		public const int OCULUS = 266; // Metadata: 0x00AE8D1A
		public const int BLUERIPPLESOUND = 267; // Metadata: 0x00AE8D1E
		public const int ENZIEN = 268; // Metadata: 0x00AE8D22
		public const int KROTOS = 269; // Metadata: 0x00AE8D26
		public const int NURULIZE = 270; // Metadata: 0x00AE8D2A
		public const int SUPERPOWERED = 271; // Metadata: 0x00AE8D2E
		public const int GOOGLE = 272; // Metadata: 0x00AE8D32
		public const int VISISONICS = 277; // Metadata: 0x00AE8D36
	}

	public static class MidiCc // TypeDefIndex: 11172
	{
		// Fields
		public const int BankSelectCoarse = 0; // Metadata: 0x00AE8D3A
		public const int ModWheelCoarse = 1; // Metadata: 0x00AE8D3E
		public const int BreathCtrlCoarse = 2; // Metadata: 0x00AE8D42
		public const int Ctrl3Coarse = 3; // Metadata: 0x00AE8D46
		public const int FootPedalCoarse = 4; // Metadata: 0x00AE8D4A
		public const int PortamentoCoarse = 5; // Metadata: 0x00AE8D4E
		public const int DataEntryCoarse = 6; // Metadata: 0x00AE8D52
		public const int VolumeCoarse = 7; // Metadata: 0x00AE8D56
		public const int BalanceCoarse = 8; // Metadata: 0x00AE8D5A
		public const int Ctrl9Coarse = 9; // Metadata: 0x00AE8D5E
		public const int PanPositionCoarse = 10; // Metadata: 0x00AE8D62
		public const int ExpressionCoarse = 11; // Metadata: 0x00AE8D66
		public const int EffectCtrl1Coarse = 12; // Metadata: 0x00AE8D6A
		public const int EffectCtrl2Coarse = 13; // Metadata: 0x00AE8D6E
		public const int Ctrl14Coarse = 14; // Metadata: 0x00AE8D72
		public const int Ctrl15Coarse = 15; // Metadata: 0x00AE8D76
		public const int GenSlider1 = 16; // Metadata: 0x00AE8D7A
		public const int GenSlider2 = 17; // Metadata: 0x00AE8D7E
		public const int GenSlider3 = 18; // Metadata: 0x00AE8D82
		public const int GenSlider4 = 19; // Metadata: 0x00AE8D86
		public const int Ctrl20Coarse = 20; // Metadata: 0x00AE8D8A
		public const int Ctrl21Coarse = 21; // Metadata: 0x00AE8D8E
		public const int Ctrl22Coarse = 22; // Metadata: 0x00AE8D92
		public const int Ctrl23Coarse = 23; // Metadata: 0x00AE8D96
		public const int Ctrl24Coarse = 24; // Metadata: 0x00AE8D9A
		public const int Ctrl25Coarse = 25; // Metadata: 0x00AE8D9E
		public const int Ctrl26Coarse = 26; // Metadata: 0x00AE8DA2
		public const int Ctrl27Coarse = 27; // Metadata: 0x00AE8DA6
		public const int Ctrl28Coarse = 28; // Metadata: 0x00AE8DAA
		public const int Ctrl29Coarse = 29; // Metadata: 0x00AE8DAE
		public const int Ctrl30Coarse = 30; // Metadata: 0x00AE8DB2
		public const int Ctrl31Coarse = 31; // Metadata: 0x00AE8DB6
		public const int BankSelectFine = 32; // Metadata: 0x00AE8DBA
		public const int ModWheelFine = 33; // Metadata: 0x00AE8DBE
		public const int BreathCtrlFine = 34; // Metadata: 0x00AE8DC2
		public const int Ctrl3Fine = 35; // Metadata: 0x00AE8DC6
		public const int FootPedalFine = 36; // Metadata: 0x00AE8DCA
		public const int PortamentoFine = 37; // Metadata: 0x00AE8DCE
		public const int DataEntryFine = 38; // Metadata: 0x00AE8DD2
		public const int VolumeFine = 39; // Metadata: 0x00AE8DD6
		public const int BalanceFine = 40; // Metadata: 0x00AE8DDA
		public const int Ctrl9Fine = 41; // Metadata: 0x00AE8DDE
		public const int PanPositionFine = 42; // Metadata: 0x00AE8DE2
		public const int ExpressionFine = 43; // Metadata: 0x00AE8DE6
		public const int EffectCtrl1Fine = 44; // Metadata: 0x00AE8DEA
		public const int EffectCtrl2Fine = 45; // Metadata: 0x00AE8DEE
		public const int Ctrl14Fine = 46; // Metadata: 0x00AE8DF2
		public const int Ctrl15Fine = 47; // Metadata: 0x00AE8DF6
		public const int Ctrl20Fine = 52; // Metadata: 0x00AE8DFA
		public const int Ctrl21Fine = 53; // Metadata: 0x00AE8DFE
		public const int Ctrl22Fine = 54; // Metadata: 0x00AE8E02
		public const int Ctrl23Fine = 55; // Metadata: 0x00AE8E06
		public const int Ctrl24Fine = 56; // Metadata: 0x00AE8E0A
		public const int Ctrl25Fine = 57; // Metadata: 0x00AE8E0E
		public const int Ctrl26Fine = 58; // Metadata: 0x00AE8E12
		public const int Ctrl27Fine = 59; // Metadata: 0x00AE8E16
		public const int Ctrl28Fine = 60; // Metadata: 0x00AE8E1A
		public const int Ctrl29Fine = 61; // Metadata: 0x00AE8E1E
		public const int Ctrl30Fine = 62; // Metadata: 0x00AE8E22
		public const int Ctrl31Fine = 63; // Metadata: 0x00AE8E26
		public const int HoldPedal = 64; // Metadata: 0x00AE8E2A
		public const int PortamentoOnOff = 65; // Metadata: 0x00AE8E2E
		public const int SustenutoPedal = 66; // Metadata: 0x00AE8E32
		public const int SoftPedal = 67; // Metadata: 0x00AE8E36
		public const int LegatoPedal = 68; // Metadata: 0x00AE8E3A
		public const int HoldPedal2 = 69; // Metadata: 0x00AE8E3E
		public const int SoundVariation = 70; // Metadata: 0x00AE8E42
		public const int SoundTimbre = 71; // Metadata: 0x00AE8E46
		public const int SoundReleaseTime = 72; // Metadata: 0x00AE8E4A
		public const int SoundAttackTime = 73; // Metadata: 0x00AE8E4E
		public const int SoundBrightness = 74; // Metadata: 0x00AE8E52
		public const int SoundCtrl6 = 75; // Metadata: 0x00AE8E56
		public const int SoundCtrl7 = 76; // Metadata: 0x00AE8E5A
		public const int SoundCtrl8 = 77; // Metadata: 0x00AE8E5E
		public const int SoundCtrl9 = 78; // Metadata: 0x00AE8E62
		public const int SoundCtrl10 = 79; // Metadata: 0x00AE8E66
		public const int GeneralButton1 = 80; // Metadata: 0x00AE8E6A
		public const int GeneralButton2 = 81; // Metadata: 0x00AE8E6E
		public const int GeneralButton3 = 82; // Metadata: 0x00AE8E72
		public const int GeneralButton4 = 83; // Metadata: 0x00AE8E76
		public const int ReverbLevel = 91; // Metadata: 0x00AE8E7A
		public const int TremoloLevel = 92; // Metadata: 0x00AE8E7E
		public const int ChorusLevel = 93; // Metadata: 0x00AE8E82
		public const int CelesteLevel = 94; // Metadata: 0x00AE8E86
		public const int PhaserLevel = 95; // Metadata: 0x00AE8E8A
		public const int DataButtonP1 = 96; // Metadata: 0x00AE8E8E
		public const int DataButtonM1 = 97; // Metadata: 0x00AE8E92
		public const int NonRegisterCoarse = 98; // Metadata: 0x00AE8E96
		public const int NonRegisterFine = 99; // Metadata: 0x00AE8E9A
		public const int AllSoundOff = 120; // Metadata: 0x00AE8E9E
		public const int AllControllersOff = 121; // Metadata: 0x00AE8EA2
		public const int LocalKeyboard = 122; // Metadata: 0x00AE8EA6
		public const int AllNotesOff = 123; // Metadata: 0x00AE8EAA
		public const int OmniModeOff = 124; // Metadata: 0x00AE8EAE
		public const int OmniModeOn = 125; // Metadata: 0x00AE8EB2
		public const int OmniMonophonicOn = 126; // Metadata: 0x00AE8EB6
		public const int OmniPolyphonicOn = 127; // Metadata: 0x00AE8EBA
	}

	public static class MidiEventType // TypeDefIndex: 11173
	{
		// Fields
		public const int Invalid = 0; // Metadata: 0x00AE8EBE
		public const int NoteOff = 128; // Metadata: 0x00AE8EC2
		public const int NoteOn = 144; // Metadata: 0x00AE8EC6
		public const int NoteAftertouch = 160; // Metadata: 0x00AE8ECA
		public const int Controller = 176; // Metadata: 0x00AE8ECE
		public const int ProgramChange = 192; // Metadata: 0x00AE8ED2
		public const int ChannelAftertouch = 208; // Metadata: 0x00AE8ED6
		public const int PitchBend = 224; // Metadata: 0x00AE8EDA
		public const int Sysex = 240; // Metadata: 0x00AE8EDE
		public const int Escape = 247; // Metadata: 0x00AE8EE2
		public const int Meta = 255; // Metadata: 0x00AE8EE6
	}

	public static class Misc // TypeDefIndex: 11174
	{
		// Fields
		public const int AK_SIMD_ALIGNMENT = 16; // Metadata: 0x00AE8EEA
		public const int AK_BUFFER_ALIGNMENT = 16; // Metadata: 0x00AE8EEE
		public const int AK_XAUDIO2_FLAGS = 0; // Metadata: 0x00AE8EF2
		public const int AK_MAX_PATH = 260; // Metadata: 0x00AE8EF6
		public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16; // Metadata: 0x00AE8EFA
		public const uint AK_MIXER_FX_SLOT = 4294967295; // Metadata: 0x00AE8EFE
		public const ulong AK_DEFAULT_LISTENER_OBJ = 0; // Metadata: 0x00AE8F02
		public const uint AK_DEFAULT_PRIORITY = 50; // Metadata: 0x00AE8F0A
		public const uint AK_MIN_PRIORITY = 0; // Metadata: 0x00AE8F0E
		public const uint AK_MAX_PRIORITY = 100; // Metadata: 0x00AE8F12
		public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50; // Metadata: 0x00AE8F16
		public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576; // Metadata: 0x00AE8F1A
		public const uint AKCOMPANYID_AUDIOKINETIC = 0; // Metadata: 0x00AE8F22
		public const uint AK_LISTENERS_MASK_ALL = 4294967295; // Metadata: 0x00AE8F26
		public const int NULL = 0; // Metadata: 0x00AE8F2A
		public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5; // Metadata: 0x00AE8F2E
		public const int AK_MAX_LANGUAGE_NAME_SIZE = 32; // Metadata: 0x00AE8F32
		public const int PANNER_NUM_STORAGE_BITS = 2; // Metadata: 0x00AE8F36
		public const int POSSOURCE_NUM_STORAGE_BITS = 2; // Metadata: 0x00AE8F3A
		public const int AK_MAX_BITS_METERING_FLAGS = 5; // Metadata: 0x00AE8F3E
		public const int AK_OS_STRUCT_ALIGN = 4; // Metadata: 0x00AE8F42
		public const int AK_64B_OS_STRUCT_ALIGN = 8; // Metadata: 0x00AE8F46
		public const bool AK_ASYNC_OPEN_DEFAULT = false; // Metadata: 0x00AE8F4A
		public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024; // Metadata: 0x00AE8F4B
		public const int AK_STANDARD_MAX_NUM_CHANNELS = 8; // Metadata: 0x00AE8F4F
		public const int AK_MAX_NUM_TEXTURE = 4; // Metadata: 0x00AE8F53
		public const int AK_MAX_REFLECT_ORDER = 4; // Metadata: 0x00AE8F57
		public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8; // Metadata: 0x00AE8F5B
		public const double AK_DEFAULT_DIFFR_SHADOW_DEGREES = 30; // Metadata: 0x00AE8F5F
		public const double AK_DEFAULT_DIFFR_SHADOW_ATTEN = 2; // Metadata: 0x00AE8F67
	}

	public static class SpecialIds // TypeDefIndex: 11175
	{
		// Fields
		public const int InvalidPoolId = -1; // Metadata: 0x00AE8F6F
		public const int DefaultPoolId = -1; // Metadata: 0x00AE8F73
		public const uint DefaultSwitchState = 0; // Metadata: 0x00AE8F77
		public const uint FallbackArgumentValueId = 0; // Metadata: 0x00AE8F7B
		public const uint InvalidAuxId = 0; // Metadata: 0x00AE8F7F
		public const uint InvalidBankId = 0; // Metadata: 0x00AE8F83
		public const uint InvalidChannelMask = 0; // Metadata: 0x00AE8F87
		public const uint InvalidDeviceId = 4294967295; // Metadata: 0x00AE8F8B
		public const uint InvalidFileId = 4294967295; // Metadata: 0x00AE8F8F
		public const uint InvalidListenerIndex = 4294967295; // Metadata: 0x00AE8F93
		public const uint InvalidOutputDeviceId = 0; // Metadata: 0x00AE8F97
		public const uint InvalidPlayingId = 0; // Metadata: 0x00AE8F9B
		public const uint InvalidPluginId = 4294967295; // Metadata: 0x00AE8F9F
		public const uint InvalidRtpcId = 0; // Metadata: 0x00AE8FA3
		public const uint InvalidUniqueId = 0; // Metadata: 0x00AE8FA7
		public const ulong InvalidGameObject = 18446744073709551615; // Metadata: 0x00AE8FAB
	}

	public static class WaveFormat // TypeDefIndex: 11176
	{
		// Fields
		public const int VAG = 65531; // Metadata: 0x00AE8FB3
		public const int AT9 = 65532; // Metadata: 0x00AE8FB7
		public const int VORBIS = 65535; // Metadata: 0x00AE8FBB
		public const int AAC = 43712; // Metadata: 0x00AE8FBF
		public const int OPUS = 12345; // Metadata: 0x00AE8FC3
		public const int XMA2 = 358; // Metadata: 0x00AE8FC7
	}
}

