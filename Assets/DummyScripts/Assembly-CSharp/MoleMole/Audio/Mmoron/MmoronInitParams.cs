/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Audio.Mmoron
{
	public class MmoronInitParams : ScriptableObject // TypeDefIndex: 11189
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _internalBasePath; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _externalBasePath; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _language; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _defaultPoolSize; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _monitorPoolSize; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _monitorQueuePoolSize; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _preparePoolSize; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _callbackManagerBufferSize; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _numSamplesPerFrame; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _maxHardwareTimeoutMs; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _useSoundBankMgrThread; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _useLEngineThread; // 0x4D
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _asyncBankLoad; // 0x4E
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Memory _memory; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Device _device; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Streaming _streaming; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Platform _platform; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SpatialAudio _spatialAudio; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ShareSets _shareSets; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Custom _custom; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MmoronCodecId _externalSourceCodecId; // 0x88
	
		// Properties
		public string internalBasePath { /* [XID] */ /* 0x00000001897CB5A0-0x00000001897CB5C0 */ get => default; } // 0x0000000186729060-0x0000000186729100 
		public string externalBasePath { /* [XID] */ /* 0x00000001897D2D00-0x00000001897D2D20 */ get => default; } // 0x0000000186728F20-0x0000000186728FC0 
		public string language { /* [XID] */ /* 0x00000001897DAA20-0x00000001897DAA40 */ get => default; } // 0x0000000186729100-0x00000001867291A0 
		public uint defaultPoolSize { /* [XID] */ /* 0x00000001897E1E60-0x00000001897E1E80 */ get => default; } // 0x0000000186728DE0-0x0000000186728E80 
		public uint monitorPoolSize { /* [XID] */ /* 0x00000001896EA7C0-0x00000001896EA7E0 */ get => default; } // 0x00000001867292E0-0x0000000186729380 
		public uint monitorQueuePoolSize { /* [XID] */ /* 0x00000001897115C0-0x00000001897115E0 */ get => default; } // 0x0000000186729380-0x0000000186729420 
		public uint preparePoolSize { /* [XID] */ /* 0x00000001897F8A40-0x00000001897F8A60 */ get => default; } // 0x0000000186729560-0x0000000186729600 
		public int callbackManagerBufferSize { /* [XID] */ /* 0x0000000189800180-0x00000001898001A0 */ get => default; } // 0x0000000186728C90-0x0000000186728D30 
		public uint numSamplesPerFrame { /* [XID] */ /* 0x0000000189807820-0x0000000189807840 */ get => default; } // 0x0000000186729420-0x00000001867294C0 
		public uint maxHardwareTimeoutMs { /* [XID] */ /* 0x000000018964FA50-0x000000018964FA70 */ get => default; } // 0x00000001867291A0-0x0000000186729240 
		public bool useSoundBankMgrThread { /* [XID] */ /* 0x000000018987C910-0x000000018987C930 */ get => default; } // 0x0000000186729880-0x0000000186729920 
		public bool useLEngineThread { /* [XID] */ /* 0x000000018981DF10-0x000000018981DF30 */ get => default; } // 0x00000001867297E0-0x0000000186729880 
		public bool asyncBankLoad { /* [XID] */ /* 0x0000000189825360-0x0000000189825380 */ get => default; } // 0x0000000186728BF0-0x0000000186728C90 
		public Memory memory { /* [XID] */ /* 0x000000018988B180-0x000000018988B1A0 */ get => default; } // 0x0000000186729240-0x00000001867292E0 
		public Device device { /* [XID] */ /* 0x0000000189834400-0x0000000189834420 */ get => default; } // 0x0000000186728E80-0x0000000186728F20 
		public Streaming streaming { /* [XID] */ /* 0x0000000189892480-0x00000001898924A0 */ get => default; } // 0x0000000186729740-0x00000001867297E0 
		public Platform platform { /* [XID] */ /* 0x0000000189BD4440-0x0000000189BD4460 */ get => default; } // 0x00000001867294C0-0x0000000186729560 
		public SpatialAudio spatialAudio { /* [XID] */ /* 0x0000000189899F10-0x0000000189899F30 */ get => default; } // 0x00000001867296A0-0x0000000186729740 
		public ShareSets shareSets { /* [XID] */ /* 0x00000001898A1220-0x00000001898A1240 */ get => default; } // 0x0000000186729600-0x00000001867296A0 
		public Custom custom { /* [XID] */ /* 0x0000000189859150-0x0000000189859170 */ get => default; } // 0x0000000186728D30-0x0000000186728DE0 
		public MmoronCodecId externalSourceCodecId { /* [XID] */ /* 0x0000000189860370-0x0000000189860390 */ get => default; } // 0x0000000186728FC0-0x0000000186729060 
	
		// Nested types
		[Serializable]
		public class Memory // TypeDefIndex: 11190
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _maxNumPools; // 0x10
	
			// Properties
			public uint maxNumPools { /* [XID] */ /* 0x000000018986F0A0-0x000000018986F0C0 */ get => default; } // 0x0000000186728AF0-0x0000000186728B90 
	
			// Constructors
			public Memory() {} // 0x0000000186728A90-0x0000000186728AF0
		}
	
		[Serializable]
		public class Device // TypeDefIndex: 11191
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _streamBufferSize; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _threadAffinity; // 0x14
	
			// Properties
			public uint streamBufferSize { /* [XID] */ /* 0x0000000189885230-0x0000000189885250 */ get => default; } // 0x000000018671D890-0x000000018671D930 
			public uint threadAffinity { /* [XID] */ /* 0x000000018988C7A0-0x000000018988C7C0 */ get => default; } // 0x000000018671D930-0x000000018671D9D0 
	
			// Constructors
			public Device() {} // 0x000000018671D830-0x000000018671D890
		}
	
		[Serializable]
		public class Streaming // TypeDefIndex: 11192
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _streamingPoolSize; // 0x10
	
			// Properties
			public uint streamingPoolSize { /* [XID] */ /* 0x000000018989B450-0x000000018989B470 */ get => default; } // 0x0000000186734F10-0x0000000186734FB0 
	
			// Constructors
			public Streaming() {} // 0x0000000186734EB0-0x0000000186734F10
		}
	
		[Serializable]
		public class Platform // TypeDefIndex: 11193
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _lowerPoolSize; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private float _memoryCutoffThreshold; // 0x14
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private int _engineThreadPriority; // 0x18
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _engineThreadAffinity; // 0x1C
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _bankThreadAffinity; // 0x20
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _monitorThreadAffinity; // 0x24
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _outputThreadAffinity; // 0x28
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private ushort _numRefillsInVoice; // 0x2C
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _sampleRate; // 0x30
	
			// Properties
			public uint lowerPoolSize { /* [XID] */ /* 0x00000001898E6430-0x00000001898E6450 */ get => default; } // 0x000000018672F380-0x000000018672F420 
			public float memoryCutoffThreshold { /* [XID] */ /* 0x0000000189B6AD50-0x0000000189B6AD70 */ get => default; } // 0x000000018672F420-0x000000018672F4D0 
			public int engineThreadPriority { /* [XID] */ /* 0x00000001898F56D0-0x00000001898F56F0 */ get => default; } // 0x000000018672F2E0-0x000000018672F380 
			public uint engineThreadAffinity { /* [XID] */ /* 0x00000001898BEEE0-0x00000001898BEF00 */ get => default; } // 0x000000018672F240-0x000000018672F2E0 
			public uint bankThreadAffinity { /* [XID] */ /* 0x0000000189904760-0x0000000189904780 */ get => default; } // 0x000000018672F1A0-0x000000018672F240 
			public uint monitorThreadAffinity { /* [XID] */ /* 0x000000018990BF60-0x000000018990BF80 */ get => default; } // 0x000000018672F4D0-0x000000018672F570 
			public uint outputThreadAffinity { /* [XID] */ /* 0x0000000189B21640-0x0000000189B21660 */ get => default; } // 0x000000018672F610-0x000000018672F6B0 
			public ushort numRefillsInVoice { /* [XID] */ /* 0x000000018991B260-0x000000018991B280 */ get => default; } // 0x000000018672F570-0x000000018672F610 
			public uint sampleRate { /* [XID] */ /* 0x0000000189922850-0x0000000189922870 */ get => default; } // 0x000000018672F6B0-0x000000018672F870 
	
			// Constructors
			public Platform() {} // 0x000000018672F140-0x000000018672F1A0
		}
	
		[Serializable]
		public class SpatialAudio // TypeDefIndex: 11194
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private bool _enable; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _poolSize; // 0x14
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _maxPropagationDepth; // 0x18
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _diffractionFlags; // 0x1C
	
			// Properties
			public bool enable { /* [XID] */ /* 0x0000000189947C50-0x0000000189947C70 */ get => default; } // 0x0000000186734850-0x00000001867348F0 
			public uint poolSize { /* [XID] */ /* 0x000000018994F330-0x000000018994F350 */ get => default; } // 0x0000000186734990-0x0000000186734A30 
			public uint maxPropagationDepth { /* [XID] */ /* 0x00000001899568E0-0x0000000189956900 */ get => default; } // 0x00000001867348F0-0x0000000186734990 
			public uint diffractionFlags { /* [XID] */ /* 0x000000018995E390-0x000000018995E3B0 */ get => default; } // 0x00000001867347B0-0x0000000186734850 
	
			// Constructors
			public SpatialAudio() {} // 0x0000000186734750-0x00000001867347B0
		}
	
		[Serializable]
		public class ShareSets // TypeDefIndex: 11195
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _motionShareSetName; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private string _controllerSpeakerShareSetName; // 0x18
	
			// Properties
			public string motionShareSetName { /* [XID] */ /* 0x0000000189739360-0x0000000189739380 */ get => default; } // 0x0000000186732D00-0x0000000186732DA0 
			public string controllerSpeakerShareSetName { /* [XID] */ /* 0x000000018997C080-0x000000018997C0A0 */ get => default; } // 0x0000000186732C60-0x0000000186732D00 
	
			// Constructors
			public ShareSets() {} // 0x0000000186732C00-0x0000000186732C60
		}
	
		[Serializable]
		public class Custom // TypeDefIndex: 11196
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private uint _bankPoolSize; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private bool _useBankPoolForPackages; // 0x14
	
			// Properties
			public uint bankPoolSize { /* [XID] */ /* 0x0000000189B5D620-0x0000000189B5D640 */ get => default; } // 0x000000018671BD80-0x000000018671BE20 
			public bool useBankPoolForPackages { /* [XID] */ /* 0x0000000189640AD0-0x0000000189640AF0 */ get => default; } // 0x000000018671BE20-0x000000018671BEC0 
	
			// Constructors
			public Custom() {} // 0x000000018671BD20-0x000000018671BD80
		}
	
		// Constructors
		public MmoronInitParams() {} // 0x0000000186728B90-0x0000000186728BF0
	}
}
