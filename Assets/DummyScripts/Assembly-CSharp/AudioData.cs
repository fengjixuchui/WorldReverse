/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AudioData // TypeDefIndex: 19323
{
	// Fields
	private static readonly ConfigMetaConfig.PathHash _ambienceConfigPathHash; // 0x00
	private static readonly ConfigMetaConfig.PathHash _avatarConfigPathHash; // 0x10
	private static readonly ConfigMetaConfig.PathHash _avatarMoveConfigPathHash; // 0x20
	private static readonly ConfigMetaConfig.PathHash _baseMoveConfigPathHash; // 0x30
	private static readonly ConfigMetaConfig.PathHash _cameraConfigPathHash; // 0x40
	private static readonly ConfigMetaConfig.PathHash _cityBlocksConfigPathHash; // 0x50
	private static readonly ConfigMetaConfig.PathHash _combatConfigPathHash; // 0x60
	private static readonly ConfigMetaConfig.PathHash _dialogConfigPathHash; // 0x70
	private static readonly ConfigMetaConfig.PathHash _gadgetConfigPathHash; // 0x80
	private static readonly ConfigMetaConfig.PathHash _generalConfigPathHash; // 0x90
	private static readonly ConfigMetaConfig.PathHash _levelConfigPathHash; // 0xA0
	private static readonly ConfigMetaConfig.PathHash _listenerConfigPathHash; // 0xB0
	private static readonly ConfigMetaConfig.PathHash _mapInfoConfigPathHash; // 0xC0
	private static readonly ConfigMetaConfig.PathHash _musicConfigPathHash; // 0xD0
	private static readonly ConfigMetaConfig.PathHash _mutualExclusionsConfigPathHash; // 0xE0
	private static readonly ConfigMetaConfig.PathHash _npcConfigPathHash; // 0xF0
	private static readonly ConfigMetaConfig.PathHash _questConfigPathHash; // 0x100
	private static readonly ConfigMetaConfig.PathHash _resourceConfigPathHash; // 0x110
	private static readonly ConfigMetaConfig.PathHash _speechConfigPathHash; // 0x120
	private static readonly ConfigMetaConfig.PathHash _surfaceTypeConfigPathHash; // 0x130
	private static readonly ConfigMetaConfig.PathHash _uiConfigPathHash; // 0x140
	private static readonly ConfigMetaConfig.PathHash _viewStateConfigPathHash; // 0x150
	private static readonly ConfigMetaConfig.PathHash _weatherConfigPathHash; // 0x160
	private static readonly ConfigMetaConfig.PathHash _eventCullingPathHash; // 0x170
	private static readonly ConfigMetaConfig.PathHash _midiConfigPathHash; // 0x180
	private static readonly HashSet<string> _uiPageIgnoreList; // 0x190

	// Properties
	public static ConfigAudioUi ui { /* [XID] */ /* 0x0000000189955DA0-0x0000000189955DE0 */ get; /* [XID] */ /* 0x0000000189960720-0x0000000189960760 */ private set; } // 0x00000001820FEAB0-0x00000001820FEB40 0x00000001820FEF10-0x00000001820FEFA0
	public static ConfigAudioNpc npc { /* [XID] */ /* 0x000000018996AE50-0x000000018996AE90 */ get; /* [XID] */ /* 0x0000000189975810-0x0000000189975850 */ private set; } // 0x0000000182100F40-0x0000000182100FD0 0x00000001821010F0-0x0000000182101180
	public static ConfigAudioLevel level { /* [XID] */ /* 0x000000018997FD00-0x000000018997FD40 */ get; /* [XID] */ /* 0x000000018998A9A0-0x000000018998A9E0 */ private set; } // 0x0000000182100910-0x00000001821009A0 0x0000000182100740-0x00000001821007D0
	public static ConfigAudioMusic music { /* [XID] */ /* 0x00000001899954D0-0x0000000189995510 */ get; /* [XID] */ /* 0x000000018999FCB0-0x000000018999FCF0 */ private set; } // 0x00000001820FEC50-0x00000001820FECE0 0x0000000182100AC0-0x0000000182100B50
	public static ConfigAudioQuest quest { /* [XID] */ /* 0x00000001899AA8C0-0x00000001899AA900 */ get; /* [XID] */ /* 0x00000001899B50E0-0x00000001899B5120 */ private set; } // 0x00000001821002C0-0x0000000182100350 0x00000001820FE990-0x00000001820FEA20
	public static ConfigAudioAvatar avatar { /* [XID] */ /* 0x00000001899BF9B0-0x00000001899BF9F0 */ get; /* [XID] */ /* 0x00000001899C9F00-0x00000001899C9F40 */ private set; } // 0x0000000182101570-0x0000000182101600 0x00000001820FE760-0x00000001820FE7F0
	public static ConfigAudioCamera camera { /* [XID] */ /* 0x00000001899D44B0-0x00000001899D44F0 */ get; /* [XID] */ /* 0x00000001899DE8B0-0x00000001899DE8F0 */ private set; } // 0x0000000182100FD0-0x0000000182101060 0x00000001820FE500-0x00000001820FE590
	public static ConfigAudioCombat combat { /* [XID] */ /* 0x00000001899E9260-0x00000001899E92A0 */ get; /* [XID] */ /* 0x00000001899F3E10-0x00000001899F3E50 */ private set; } // 0x0000000182100470-0x0000000182100500 0x0000000182100BE0-0x0000000182100C70
	public static ConfigAudioDialog dialog { /* [XID] */ /* 0x00000001899FE2D0-0x00000001899FE310 */ get; /* [XID] */ /* 0x0000000189A08770-0x0000000189A087B0 */ private set; } // 0x0000000182100A30-0x0000000182100AC0 0x00000001821006B0-0x0000000182100740
	public static ConfigAudioGadget gadget { /* [XID] */ /* 0x0000000189A12F60-0x0000000189A12FA0 */ get; /* [XID] */ /* 0x0000000189A1D210-0x0000000189A1D250 */ private set; } // 0x00000001821003E0-0x0000000182100470 0x00000001820FEA20-0x00000001820FEAB0
	public static ConfigAudioGeneral general { /* [XID] */ /* 0x0000000189A27660-0x0000000189A276A0 */ get; /* [XID] */ /* 0x0000000189A31B20-0x0000000189A31B60 */ private set; } // 0x0000000182100C70-0x0000000182100D00 0x00000001820FE900-0x00000001820FE990
	public static ConfigAudioWeather weather { /* [XID] */ /* 0x0000000189A3C2D0-0x0000000189A3C310 */ get; /* [XID] */ /* 0x0000000189A46C50-0x0000000189A46C90 */ private set; } // 0x0000000182100E20-0x0000000182100EB0 0x00000001821001A0-0x0000000182100230
	public static ConfigAvatarSpeech speech { /* [XID] */ /* 0x0000000189A51450-0x0000000189A51490 */ get; /* [XID] */ /* 0x0000000189A5BDE0-0x0000000189A5BE20 */ private set; } // 0x0000000182100500-0x0000000182100590 0x00000001820FE2C0-0x00000001820FE350
	public static ConfigAudioMapInfo mapInfo { /* [XID] */ /* 0x0000000189A665C0-0x0000000189A66600 */ get; /* [XID] */ /* 0x0000000189A70D60-0x0000000189A70DA0 */ private set; } // 0x00000001820FE470-0x00000001820FE500 0x0000000182100230-0x00000001821002C0
	public static ConfigAudioAmbience ambience { /* [XID] */ /* 0x0000000189A7B820-0x0000000189A7B860 */ get; /* [XID] */ /* 0x0000000189A85FF0-0x0000000189A86030 */ private set; } // 0x0000000182101600-0x0000000182101690 0x00000001821009A0-0x0000000182100A30
	public static ConfigAudioBaseMove baseMove { /* [XID] */ /* 0x0000000189A90AD0-0x0000000189A90B10 */ get; /* [XID] */ /* 0x0000000189A9B240-0x0000000189A9B280 */ private set; } // 0x00000001820FE350-0x00000001820FE3E0 0x0000000182100080-0x0000000182100110
	public static ConfigAudioListener listener { /* [XID] */ /* 0x0000000189AA56A0-0x0000000189AA56E0 */ get; /* [XID] */ /* 0x0000000189AAFE90-0x0000000189AAFED0 */ private set; } // 0x0000000182100D00-0x0000000182100D90 0x0000000182100B50-0x0000000182100BE0
	public static ConfigAudioResource resource { /* [XID] */ /* 0x0000000189ABAAD0-0x0000000189ABAB10 */ get; /* [XID] */ /* 0x0000000189AC5430-0x0000000189AC5470 */ private set; } // 0x0000000182100590-0x0000000182100620 0x0000000182100110-0x00000001821001A0
	public static ConfigAudioAvatarMove avatarMove { /* [XID] */ /* 0x0000000189ACF970-0x0000000189ACF9B0 */ get; /* [XID] */ /* 0x0000000189ADA680-0x0000000189ADA6C0 */ private set; } // 0x0000000182101B30-0x0000000182101BC0 0x0000000182101830-0x00000001821018C0
	public static ConfigAudioCityBlocks cityBlocks { /* [XID] */ /* 0x0000000189AE5240-0x0000000189AE5280 */ get; /* [XID] */ /* 0x0000000189AEFD20-0x0000000189AEFD60 */ private set; } // 0x00000001821018C0-0x0000000182101950 0x0000000182101950-0x00000001821019E0
	public static ConfigAudioSurfaceType surfaceType { /* [XID] */ /* 0x0000000189AFA400-0x0000000189AFA440 */ get; /* [XID] */ /* 0x0000000189B04600-0x0000000189B04640 */ private set; } // 0x0000000182100620-0x00000001821006B0 0x00000001820FFFF0-0x0000000182100080
	public static ConfigAudioGameViewState viewState { /* [XID] */ /* 0x0000000189B0EE50-0x0000000189B0EE90 */ get; /* [XID] */ /* 0x0000000189B19230-0x0000000189B19270 */ private set; } // 0x0000000182101690-0x0000000182101720 0x0000000182101450-0x00000001821014E0
	public static ConfigAudioMutualExclusion mutualExclusions { /* [XID] */ /* 0x00000001897FE8B0-0x00000001897FE8F0 */ get; /* [XID] */ /* 0x0000000189B2DE10-0x0000000189B2DE50 */ private set; } // 0x0000000182100EB0-0x0000000182100F40 0x0000000182101060-0x00000001821010F0
	public static ConfigAudioEventCulling eventCulling { /* [XID] */ /* 0x0000000189B38370-0x0000000189B383B0 */ get; /* [XID] */ /* 0x0000000189B42E90-0x0000000189B42ED0 */ private set; } // 0x00000001820FE3E0-0x00000001820FE470 0x0000000182100350-0x00000001821003E0
	public static ConfigAudioMIDI midi { /* [XID] */ /* 0x0000000189B4D5D0-0x0000000189B4D610 */ get; /* [XID] */ /* 0x0000000189B57FE0-0x0000000189B58020 */ private set; } // 0x0000000182100D90-0x0000000182100E20 0x00000001821014E0-0x0000000182101570
	public static uint avatarVoiceSwitchKey { /* [XID] */ /* 0x0000000189B622B0-0x0000000189B622D0 */ get; } // 0x00000001820FEB40-0x00000001820FEC50 
	public static uint avatarBodyTypeSwitchKey { /* [XID] */ /* 0x0000000189B69F70-0x0000000189B69F90 */ get; } // 0x00000001820FE7F0-0x00000001820FE900 
	public static float fakeAvatarDistance { /* [XID] */ /* 0x00000001898E6640-0x00000001898E6660 */ get; } // 0x0000000182101720-0x0000000182101830 

	// Nested types
	public class ConfigAudioIndexAbstraction : ConfigObjectAbstraction<ConfigAudioIndex> // TypeDefIndex: 19324
	{
		// Constructors
		public ConfigAudioIndexAbstraction() {} // 0x0000000182103980-0x00000001821039F0

		// Methods
		// [XID] // 0x0000000189BA7D90-0x0000000189BA7DB0
		protected override ConfigAudioIndex CreateInstance() => default; // 0x00000001821036F0-0x00000001821037B0
		// [XID] // 0x0000000189BAF200-0x0000000189BAF220
		protected override bool FromBinary(ConfigAudioIndex instance, ByteArray bytes) => default; // 0x00000001821037B0-0x00000001821038A0
		// [XID] // 0x0000000189BB6870-0x0000000189BB6890
		protected override bool FromJson(ConfigAudioIndex instance, JSONNode json) => default; // 0x00000001821038A0-0x0000000182103980
	}

	public class ConfigAudioAmbienceAbstraction : ConfigObjectAbstraction<ConfigAudioAmbience> // TypeDefIndex: 19325
	{
		// Constructors
		public ConfigAudioAmbienceAbstraction() {} // 0x00000001820E65E0-0x00000001820E6650

		// Methods
		// [XID] // 0x0000000189BBDEB0-0x0000000189BBDED0
		protected override ConfigAudioAmbience CreateInstance() => default; // 0x00000001820E6350-0x00000001820E6410
		// [XID] // 0x0000000189BC5BA0-0x0000000189BC5BC0
		protected override bool FromBinary(ConfigAudioAmbience instance, ByteArray bytes) => default; // 0x00000001820E6410-0x00000001820E6500
		// [XID] // 0x0000000189BCD5E0-0x0000000189BCD600
		protected override bool FromJson(ConfigAudioAmbience instance, JSONNode json) => default; // 0x00000001820E6500-0x00000001820E65E0
	}

	public class ConfigAudioAvatarAbstraction : ConfigObjectAbstraction<ConfigAudioAvatar> // TypeDefIndex: 19326
	{
		// Constructors
		public ConfigAudioAvatarAbstraction() {} // 0x00000001820E53E0-0x00000001820E5450

		// Methods
		// [XID] // 0x0000000189BD4B30-0x0000000189BD4B50
		protected override ConfigAudioAvatar CreateInstance() => default; // 0x00000001820E5150-0x00000001820E5210
		// [XID] // 0x0000000189BDC5C0-0x0000000189BDC5E0
		protected override bool FromBinary(ConfigAudioAvatar instance, ByteArray bytes) => default; // 0x00000001820E5210-0x00000001820E5300
		// [XID] // 0x00000001895E8F90-0x00000001895E8FB0
		protected override bool FromJson(ConfigAudioAvatar instance, JSONNode json) => default; // 0x00000001820E5300-0x00000001820E53E0
	}

	public class ConfigAudioAvatarMoveAbstraction : ConfigObjectAbstraction<ConfigAudioAvatarMove> // TypeDefIndex: 19327
	{
		// Constructors
		public ConfigAudioAvatarMoveAbstraction() {} // 0x00000001820E6FC0-0x00000001820E7030

		// Methods
		// [XID] // 0x00000001895F0740-0x00000001895F0760
		protected override ConfigAudioAvatarMove CreateInstance() => default; // 0x00000001820E6D30-0x00000001820E6DF0
		// [XID] // 0x00000001895F8150-0x00000001895F8170
		protected override bool FromBinary(ConfigAudioAvatarMove instance, ByteArray bytes) => default; // 0x00000001820E6DF0-0x00000001820E6EE0
		// [XID] // 0x00000001895FF6B0-0x00000001895FF6D0
		protected override bool FromJson(ConfigAudioAvatarMove instance, JSONNode json) => default; // 0x00000001820E6EE0-0x00000001820E6FC0
	}

	public class ConfigAudioBaseMoveAbstraction : ConfigObjectAbstraction<ConfigAudioBaseMove> // TypeDefIndex: 19328
	{
		// Constructors
		public ConfigAudioBaseMoveAbstraction() {} // 0x0000000182102A60-0x0000000182102AD0

		// Methods
		// [XID] // 0x0000000189606E00-0x0000000189606E20
		protected override ConfigAudioBaseMove CreateInstance() => default; // 0x00000001821027D0-0x0000000182102890
		// [XID] // 0x000000018960E6E0-0x000000018960E700
		protected override bool FromBinary(ConfigAudioBaseMove instance, ByteArray bytes) => default; // 0x0000000182102890-0x0000000182102980
		// [XID] // 0x0000000189615DC0-0x0000000189615DE0
		protected override bool FromJson(ConfigAudioBaseMove instance, JSONNode json) => default; // 0x0000000182102980-0x0000000182102A60
	}

	public class ConfigAudioCameraAbstraction : ConfigObjectAbstraction<ConfigAudioCamera> // TypeDefIndex: 19329
	{
		// Constructors
		public ConfigAudioCameraAbstraction() {} // 0x00000001820E4DE0-0x00000001820E4E50

		// Methods
		// [XID] // 0x000000018961D6D0-0x000000018961D6F0
		protected override ConfigAudioCamera CreateInstance() => default; // 0x00000001820E4B50-0x00000001820E4C10
		// [XID] // 0x0000000189624B10-0x0000000189624B30
		protected override bool FromBinary(ConfigAudioCamera instance, ByteArray bytes) => default; // 0x00000001820E4C10-0x00000001820E4D00
		// [XID] // 0x000000018962C2D0-0x000000018962C2F0
		protected override bool FromJson(ConfigAudioCamera instance, JSONNode json) => default; // 0x00000001820E4D00-0x00000001820E4DE0
	}

	public class ConfigAudioCityBlocksAbstraction : ConfigObjectAbstraction<ConfigAudioCityBlocks> // TypeDefIndex: 19330
	{
		// Constructors
		public ConfigAudioCityBlocksAbstraction() {} // 0x0000000182104220-0x0000000182104290

		// Methods
		// [XID] // 0x0000000189633DF0-0x0000000189633E10
		protected override ConfigAudioCityBlocks CreateInstance() => default; // 0x0000000182103F90-0x0000000182104050
		// [XID] // 0x000000018963B5B0-0x000000018963B5D0
		protected override bool FromBinary(ConfigAudioCityBlocks instance, ByteArray bytes) => default; // 0x0000000182104050-0x0000000182104140
		// [XID] // 0x0000000189642E40-0x0000000189642E60
		protected override bool FromJson(ConfigAudioCityBlocks instance, JSONNode json) => default; // 0x0000000182104140-0x0000000182104220
	}

	public class ConfigAudioCombatAbstraction : ConfigObjectAbstraction<ConfigAudioCombat> // TypeDefIndex: 19331
	{
		// Constructors
		public ConfigAudioCombatAbstraction() {} // 0x0000000182103380-0x00000001821033F0

		// Methods
		// [XID] // 0x000000018964A520-0x000000018964A540
		protected override ConfigAudioCombat CreateInstance() => default; // 0x00000001821030F0-0x00000001821031B0
		// [XID] // 0x0000000189651CC0-0x0000000189651CE0
		protected override bool FromBinary(ConfigAudioCombat instance, ByteArray bytes) => default; // 0x00000001821031B0-0x00000001821032A0
		// [XID] // 0x00000001896594D0-0x00000001896594F0
		protected override bool FromJson(ConfigAudioCombat instance, JSONNode json) => default; // 0x00000001821032A0-0x0000000182103380
	}

	public class ConfigAudioDialogAbstraction : ConfigObjectAbstraction<ConfigAudioDialog> // TypeDefIndex: 19332
	{
		// Constructors
		public ConfigAudioDialogAbstraction() {} // 0x00000001820E56E0-0x00000001820E5750

		// Methods
		// [XID] // 0x0000000189660B50-0x0000000189660B70
		protected override ConfigAudioDialog CreateInstance() => default; // 0x00000001820E5450-0x00000001820E5510
		// [XID] // 0x0000000189668540-0x0000000189668560
		protected override bool FromBinary(ConfigAudioDialog instance, ByteArray bytes) => default; // 0x00000001820E5510-0x00000001820E5600
		// [XID] // 0x000000018966FFF0-0x0000000189670010
		protected override bool FromJson(ConfigAudioDialog instance, JSONNode json) => default; // 0x00000001820E5600-0x00000001820E56E0
	}

	public class ConfigAudioGadgetAbstraction : ConfigObjectAbstraction<ConfigAudioGadget> // TypeDefIndex: 19333
	{
		// Constructors
		public ConfigAudioGadgetAbstraction() {} // 0x00000001820E50E0-0x00000001820E5150

		// Methods
		// [XID] // 0x0000000189677930-0x0000000189677950
		protected override ConfigAudioGadget CreateInstance() => default; // 0x00000001820E4E50-0x00000001820E4F10
		// [XID] // 0x000000018967EE20-0x000000018967EE40
		protected override bool FromBinary(ConfigAudioGadget instance, ByteArray bytes) => default; // 0x00000001820E4F10-0x00000001820E5000
		// [XID] // 0x0000000189686770-0x0000000189686790
		protected override bool FromJson(ConfigAudioGadget instance, JSONNode json) => default; // 0x00000001820E5000-0x00000001820E50E0
	}

	public class ConfigAudioGeneralAbstraction : ConfigObjectAbstraction<ConfigAudioGeneral> // TypeDefIndex: 19334
	{
		// Constructors
		public ConfigAudioGeneralAbstraction() {} // 0x00000001820E69C0-0x00000001820E6A30

		// Methods
		// [XID] // 0x000000018968E4F0-0x000000018968E510
		protected override ConfigAudioGeneral CreateInstance() => default; // 0x00000001820E6730-0x00000001820E67F0
		// [XID] // 0x0000000189695E90-0x0000000189695EB0
		protected override bool FromBinary(ConfigAudioGeneral instance, ByteArray bytes) => default; // 0x00000001820E67F0-0x00000001820E68E0
		// [XID] // 0x000000018969D5B0-0x000000018969D5D0
		protected override bool FromJson(ConfigAudioGeneral instance, JSONNode json) => default; // 0x00000001820E68E0-0x00000001820E69C0
	}

	public class ConfigAudioGameViewStateAbstraction : ConfigObjectAbstraction<ConfigAudioGameViewState> // TypeDefIndex: 19335
	{
		// Constructors
		public ConfigAudioGameViewStateAbstraction() {} // 0x00000001820E59E0-0x00000001820E5A50

		// Methods
		// [XID] // 0x00000001896A45E0-0x00000001896A4600
		protected override ConfigAudioGameViewState CreateInstance() => default; // 0x00000001820E5750-0x00000001820E5810
		// [XID] // 0x00000001896ABE10-0x00000001896ABE30
		protected override bool FromBinary(ConfigAudioGameViewState instance, ByteArray bytes) => default; // 0x00000001820E5810-0x00000001820E5900
		// [XID] // 0x00000001896B2FF0-0x00000001896B3010
		protected override bool FromJson(ConfigAudioGameViewState instance, JSONNode json) => default; // 0x00000001820E5900-0x00000001820E59E0
	}

	public class ConfigAudioLevelAbstraction : ConfigObjectAbstraction<ConfigAudioLevel> // TypeDefIndex: 19336
	{
		// Constructors
		public ConfigAudioLevelAbstraction() {} // 0x00000001820E6CC0-0x00000001820E6D30

		// Methods
		// [XID] // 0x00000001896BA7D0-0x00000001896BA7F0
		protected override ConfigAudioLevel CreateInstance() => default; // 0x00000001820E6A30-0x00000001820E6AF0
		// [XID] // 0x00000001896C18A0-0x00000001896C18C0
		protected override bool FromBinary(ConfigAudioLevel instance, ByteArray bytes) => default; // 0x00000001820E6AF0-0x00000001820E6BE0
		// [XID] // 0x00000001896C8FF0-0x00000001896C9010
		protected override bool FromJson(ConfigAudioLevel instance, JSONNode json) => default; // 0x00000001820E6BE0-0x00000001820E6CC0
	}

	public class ConfigAudioListenerAbstraction : ConfigObjectAbstraction<ConfigAudioListener> // TypeDefIndex: 19337
	{
		// Constructors
		public ConfigAudioListenerAbstraction() {} // 0x0000000182102D60-0x0000000182102DD0

		// Methods
		// [XID] // 0x00000001896D09C0-0x00000001896D09E0
		protected override ConfigAudioListener CreateInstance() => default; // 0x0000000182102AD0-0x0000000182102B90
		// [XID] // 0x00000001896D7F10-0x00000001896D7F30
		protected override bool FromBinary(ConfigAudioListener instance, ByteArray bytes) => default; // 0x0000000182102B90-0x0000000182102C80
		// [XID] // 0x00000001896DF7C0-0x00000001896DF7E0
		protected override bool FromJson(ConfigAudioListener instance, JSONNode json) => default; // 0x0000000182102C80-0x0000000182102D60
	}

	public class ConfigAudioMapInfoAbstraction : ConfigObjectAbstraction<ConfigAudioMapInfo> // TypeDefIndex: 19338
	{
		// Constructors
		public ConfigAudioMapInfoAbstraction() {} // 0x0000000183644610-0x0000000183644760

		// Methods
		// [XID] // 0x00000001896E6BC0-0x00000001896E6BE0
		protected override ConfigAudioMapInfo CreateInstance() => default; // 0x0000000183644380-0x0000000183644440
		// [XID] // 0x00000001896EE0F0-0x00000001896EE110
		protected override bool FromBinary(ConfigAudioMapInfo instance, ByteArray bytes) => default; // 0x0000000183644440-0x0000000183644530
		// [XID] // 0x00000001896F5900-0x00000001896F5920
		protected override bool FromJson(ConfigAudioMapInfo instance, JSONNode json) => default; // 0x0000000183644530-0x0000000183644610
	}

	public class ConfigAudioMusicAbstraction : ConfigObjectAbstraction<ConfigAudioMusic> // TypeDefIndex: 19339
	{
		// Constructors
		public ConfigAudioMusicAbstraction() {} // 0x0000000182103680-0x00000001821036F0

		// Methods
		// [XID] // 0x00000001896FD0D0-0x00000001896FD0F0
		protected override ConfigAudioMusic CreateInstance() => default; // 0x00000001821033F0-0x00000001821034B0
		// [XID] // 0x0000000189704650-0x0000000189704670
		protected override bool FromBinary(ConfigAudioMusic instance, ByteArray bytes) => default; // 0x00000001821034B0-0x00000001821035A0
		// [XID] // 0x000000018970BD10-0x000000018970BD30
		protected override bool FromJson(ConfigAudioMusic instance, JSONNode json) => default; // 0x00000001821035A0-0x0000000182103680
	}

	public class ConfigAudioMutualExclusionAbstraction : ConfigObjectAbstraction<ConfigAudioMutualExclusion> // TypeDefIndex: 19340
	{
		// Constructors
		public ConfigAudioMutualExclusionAbstraction() {} // 0x0000000183644310-0x0000000183644380

		// Methods
		// [XID] // 0x00000001897136A0-0x00000001897136C0
		protected override ConfigAudioMutualExclusion CreateInstance() => default; // 0x0000000183644080-0x0000000183644140
		// [XID] // 0x000000018971AE60-0x000000018971AE80
		protected override bool FromBinary(ConfigAudioMutualExclusion instance, ByteArray bytes) => default; // 0x0000000183644140-0x0000000183644230
		// [XID] // 0x00000001897221E0-0x0000000189722200
		protected override bool FromJson(ConfigAudioMutualExclusion instance, JSONNode json) => default; // 0x0000000183644230-0x0000000183644310
	}

	public class ConfigAudioNpcAbstraction : ConfigObjectAbstraction<ConfigAudioNpc> // TypeDefIndex: 19341
	{
		// Constructors
		public ConfigAudioNpcAbstraction() {} // 0x00000001820E47E0-0x00000001820E4850

		// Methods
		// [XID] // 0x0000000189729900-0x0000000189729920
		protected override ConfigAudioNpc CreateInstance() => default; // 0x00000001820E4550-0x00000001820E4610
		// [XID] // 0x00000001897310A0-0x00000001897310C0
		protected override bool FromBinary(ConfigAudioNpc instance, ByteArray bytes) => default; // 0x00000001820E4610-0x00000001820E4700
		// [XID] // 0x0000000189738970-0x0000000189738990
		protected override bool FromJson(ConfigAudioNpc instance, JSONNode json) => default; // 0x00000001820E4700-0x00000001820E47E0
	}

	public class ConfigAudioQuestAbstraction : ConfigObjectAbstraction<ConfigAudioQuest> // TypeDefIndex: 19342
	{
		// Constructors
		public ConfigAudioQuestAbstraction() {} // 0x0000000182103060-0x00000001821030F0

		// Methods
		// [XID] // 0x0000000189740700-0x0000000189740720
		protected override ConfigAudioQuest CreateInstance() => default; // 0x0000000182102DD0-0x0000000182102E90
		// [XID] // 0x0000000189747A50-0x0000000189747A70
		protected override bool FromBinary(ConfigAudioQuest instance, ByteArray bytes) => default; // 0x0000000182102E90-0x0000000182102F80
		// [XID] // 0x000000018974F210-0x000000018974F230
		protected override bool FromJson(ConfigAudioQuest instance, JSONNode json) => default; // 0x0000000182102F80-0x0000000182103060
	}

	public class ConfigAudioResourceAbstraction : ConfigObjectAbstraction<ConfigAudioResource> // TypeDefIndex: 19343
	{
		// Constructors
		public ConfigAudioResourceAbstraction() {} // 0x00000001820E62E0-0x00000001820E6350

		// Methods
		// [XID] // 0x0000000189756920-0x0000000189756940
		protected override ConfigAudioResource CreateInstance() => default; // 0x00000001820E6050-0x00000001820E6110
		// [XID] // 0x000000018975DD70-0x000000018975DD90
		protected override bool FromBinary(ConfigAudioResource instance, ByteArray bytes) => default; // 0x00000001820E6110-0x00000001820E6200
		// [XID] // 0x00000001897653D0-0x00000001897653F0
		protected override bool FromJson(ConfigAudioResource instance, JSONNode json) => default; // 0x00000001820E6200-0x00000001820E62E0
	}

	public class ConfigAudioSurfaceTypeAbstraction : ConfigObjectAbstraction<ConfigAudioSurfaceType> // TypeDefIndex: 19344
	{
		// Constructors
		public ConfigAudioSurfaceTypeAbstraction() {} // 0x0000000182104520-0x0000000182104590

		// Methods
		// [XID] // 0x000000018976CE20-0x000000018976CE40
		protected override ConfigAudioSurfaceType CreateInstance() => default; // 0x0000000182104290-0x0000000182104350
		// [XID] // 0x0000000189774230-0x0000000189774250
		protected override bool FromBinary(ConfigAudioSurfaceType instance, ByteArray bytes) => default; // 0x0000000182104350-0x0000000182104440
		// [XID] // 0x000000018977BA40-0x000000018977BA60
		protected override bool FromJson(ConfigAudioSurfaceType instance, JSONNode json) => default; // 0x0000000182104440-0x0000000182104520
	}

	public class ConfigAudioUiAbstraction : ConfigObjectAbstraction<ConfigAudioUi> // TypeDefIndex: 19345
	{
		// Constructors
		public ConfigAudioUiAbstraction() {} // 0x0000000182102680-0x00000001821026F0

		// Methods
		// [XID] // 0x0000000189783450-0x0000000189783470
		protected override ConfigAudioUi CreateInstance() => default; // 0x00000001821023F0-0x00000001821024B0
		// [XID] // 0x000000018978AAC0-0x000000018978AAE0
		protected override bool FromBinary(ConfigAudioUi instance, ByteArray bytes) => default; // 0x00000001821024B0-0x00000001821025A0
		// [XID] // 0x0000000189792120-0x0000000189792140
		protected override bool FromJson(ConfigAudioUi instance, JSONNode json) => default; // 0x00000001821025A0-0x0000000182102680
	}

	public class ConfigAudioWeatherAbstraction : ConfigObjectAbstraction<ConfigAudioWeather> // TypeDefIndex: 19346
	{
		// Constructors
		public ConfigAudioWeatherAbstraction() {} // 0x00000001820E4AE0-0x00000001820E4B50

		// Methods
		// [XID] // 0x0000000189799710-0x0000000189799730
		protected override ConfigAudioWeather CreateInstance() => default; // 0x00000001820E4850-0x00000001820E4910
		// [XID] // 0x00000001897A1540-0x00000001897A1560
		protected override bool FromBinary(ConfigAudioWeather instance, ByteArray bytes) => default; // 0x00000001820E4910-0x00000001820E4A00
		// [XID] // 0x00000001897A8E20-0x00000001897A8E40
		protected override bool FromJson(ConfigAudioWeather instance, JSONNode json) => default; // 0x00000001820E4A00-0x00000001820E4AE0
	}

	public class ConfigAvatarSpeechAbstraction : ConfigObjectAbstraction<ConfigAvatarSpeech> // TypeDefIndex: 19347
	{
		// Constructors
		public ConfigAvatarSpeechAbstraction() {} // 0x0000000182103EB0-0x0000000182103F90

		// Methods
		// [XID] // 0x00000001897B0700-0x00000001897B0720
		protected override ConfigAvatarSpeech CreateInstance() => default; // 0x0000000182103C20-0x0000000182103CE0
		// [XID] // 0x00000001897B8480-0x00000001897B84A0
		protected override bool FromBinary(ConfigAvatarSpeech instance, ByteArray bytes) => default; // 0x0000000182103CE0-0x0000000182103DD0
		// [XID] // 0x00000001897C0540-0x00000001897C0560
		protected override bool FromJson(ConfigAvatarSpeech instance, JSONNode json) => default; // 0x0000000182103DD0-0x0000000182103EB0
	}

	public class ConfigSettingAbstraction : ConfigObjectAbstraction<ConfigAudioSetting> // TypeDefIndex: 19348
	{
		// Constructors
		public ConfigSettingAbstraction() {} // 0x00000001820E5FE0-0x00000001820E6050

		// Methods
		// [XID] // 0x00000001897C7DD0-0x00000001897C7DF0
		protected override ConfigAudioSetting CreateInstance() => default; // 0x00000001820E5D50-0x00000001820E5E10
		// [XID] // 0x00000001897CF090-0x00000001897CF0B0
		protected override bool FromBinary(ConfigAudioSetting instance, ByteArray bytes) => default; // 0x00000001820E5E10-0x00000001820E5F00
		// [XID] // 0x00000001897D6820-0x00000001897D6840
		protected override bool FromJson(ConfigAudioSetting instance, JSONNode json) => default; // 0x00000001820E5F00-0x00000001820E5FE0
	}

	public class ConfigAudioEventCullingAbstraction : ConfigObjectAbstraction<ConfigAudioEventCulling> // TypeDefIndex: 19349
	{
		// Constructors
		public ConfigAudioEventCullingAbstraction() {} // 0x0000000182104820-0x0000000182104890

		// Methods
		// [XID] // 0x00000001897DE050-0x00000001897DE070
		protected override ConfigAudioEventCulling CreateInstance() => default; // 0x0000000182104590-0x0000000182104650
		// [XID] // 0x00000001897E5A60-0x00000001897E5A80
		protected override bool FromBinary(ConfigAudioEventCulling instance, ByteArray bytes) => default; // 0x0000000182104650-0x0000000182104740
		// [XID] // 0x00000001897ED550-0x00000001897ED570
		protected override bool FromJson(ConfigAudioEventCulling instance, JSONNode json) => default; // 0x0000000182104740-0x0000000182104820
	}

	public class ConfigAudioMidiAbstraction : ConfigObjectAbstraction<ConfigAudioMIDI> // TypeDefIndex: 19350
	{
		// Constructors
		public ConfigAudioMidiAbstraction() {} // 0x00000001820E5CE0-0x00000001820E5D50

		// Methods
		// [XID] // 0x00000001897F4CF0-0x00000001897F4D10
		protected override ConfigAudioMIDI CreateInstance() => default; // 0x00000001820E5A50-0x00000001820E5B10
		// [XID] // 0x00000001897FC780-0x00000001897FC7A0
		protected override bool FromBinary(ConfigAudioMIDI instance, ByteArray bytes) => default; // 0x00000001820E5B10-0x00000001820E5C00
		// [XID] // 0x0000000189803D10-0x0000000189803D30
		protected override bool FromJson(ConfigAudioMIDI instance, JSONNode json) => default; // 0x00000001820E5C00-0x00000001820E5CE0
	}

	// Constructors
	static AudioData() {} // 0x0000000182101BC0-0x00000001821023F0

	// Methods
	// [XID] // 0x0000000189B78B40-0x0000000189B78B60
	public static void ReloadFromFile() {} // 0x00000001820FEFA0-0x00000001820FFFF0
	[DebuggerHidden] // 0x0000000189B7FF90-0x0000000189B7FFD0
	// [XID] // 0x0000000189B7FF90-0x0000000189B7FFD0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC76A */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001821007D0-0x0000000182100910
	// [XID] // 0x0000000189B8A6D0-0x0000000189B8A6F0
	public static bool ShouldIgnorePageAction(string contextName) => default; // 0x00000001821019E0-0x0000000182101B30
	// [XID] // 0x0000000189B91C80-0x0000000189B91CA0
	public static bool IsVoiceEvent(uint eventId) => default; // 0x00000001820FE590-0x00000001820FE760
	// [XID] // 0x0000000189B99180-0x0000000189B991A0
	private static void StructurizeData() {} // 0x0000000182101180-0x0000000182101450
	// [XID] // 0x0000000189BA0570-0x0000000189BA0590
	private static void InflateUiPageIgnoreList() {} // 0x00000001820FECE0-0x00000001820FEF10
}

