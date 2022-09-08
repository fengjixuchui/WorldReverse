/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public abstract class Controller // TypeDefIndex: 3620
	{
		// Fields
		public readonly int id; // 0x10
		protected string _tag; // 0x18
		protected string _name; // 0x20
		protected string _hardwareName; // 0x28
		protected readonly ControllerType _type; // 0x30
		internal readonly Guid OtVFjwsBdyyNFQHLWfYqCKpUyfa; // 0x34
		protected string _hardwareIdentifier; // 0x48
		protected bool _isConnected; // 0x50
		private Extension RlhCPmWdFbcKPPhKmYBnLApskyE; // 0x58
		private bool PAfqntGWZaNgzmZFIOyQPuJGOCq; // 0x60
		private ControllerIdentifier aDwkabFLbtXZmwugTIBtMgVSqlG; // 0x68
		internal int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x98
		protected readonly int _buttonCount; // 0x9C
		protected readonly Button[] buttons; // 0xA0
		protected readonly ReadOnlyCollection<Button> buttons_readOnly; // 0xA8
		private readonly IList<Element> SERTGFptqMjtvIPNWFYznVbzAwf; // 0xB0
		private readonly ReadOnlyCollection<Element> uYCZQbMkrLLRfaHNIaSBlhhdXMi; // 0xB8
		internal readonly InputSource CpNbHtCijSICCnUFhUdnSnuZaCd; // 0xC0
		internal readonly ControllerDataUpdater ybiZyKuVmvsrOHqZzdmfwidXkdm; // 0xC8
		internal readonly HardwareControllerMap_Game RCNejcvnZtMAmgendVbiwgNYmdD; // 0xD0
		internal uint ZiBWJqHGYvQSltkdFfMKoNywXJD; // 0xD8
		private uint FWDlwTNZgemXOaqiatNLXlgYHcV; // 0xDC
		private uint GjRDtXznCCAhvyIdBylboNNJdWR; // 0xE0
		private Action<bool> TEEhmdIRbRbrcoqQUkwTruKySqN; // 0xE8
		private IControllerTemplate[] ubsIBKLQBnosVvePVOQElRJzKU; // 0xF0
		private ReadOnlyCollection<IControllerTemplate> czlfGCECIdSwszuDQfcKYYwvrIv; // 0xF8
		private static Func<Controller, Guid, bool> BgKUxSWlNcnOePyUgthSnZxKpuE; // 0x00
		private static Func<Controller, System.Type, bool> IHgEnxXOAFKpWdCnGWIIqJUAKTj; // 0x08
	
		// Properties
		internal bool wasPollingPrev { get; } // 0x0000000185E84D80-0x0000000185E84E20 
		public bool enabled { get; set; } // 0x0000000185E84260-0x0000000185E84330 0x0000000185E85020-0x0000000185E850A0
		public string name { get; } // 0x0000000185E849A0-0x0000000185E84AA0 
		public string tag { get; set; } // 0x0000000185E84AA0-0x0000000185E84BA0 0x0000000185E851A0-0x0000000185E85270
		public string hardwareName { get; } // 0x0000000185E84530-0x0000000185E84630 
		public ControllerType type { get; } // 0x0000000185E84CB0-0x0000000185E84D80 
		public Guid hardwareTypeGuid { get; } // 0x0000000185E84630-0x0000000185E84750 
		public abstract Guid deviceInstanceGuid { get; }
		public ControllerIdentifier identifier { get; } // 0x0000000185E84750-0x0000000185E847D0 
		internal bool isConnected { get; set; } // 0x0000000185E850A0-0x0000000185E851A0
		public string hardwareIdentifier { get; } // 0x0000000185E84430-0x0000000185E84530 
		public string mapTypeString { get; } // 0x0000000185E848D0-0x0000000185E849A0 
		public int buttonCount { get; } // 0x0000000185E84160-0x0000000185E84260 
		public IList<Button> Buttons { get; } // 0x0000000185E83F70-0x0000000185E84050 
		public Extension extension { get; } // 0x0000000185E84330-0x0000000185E84430 
		public IList<ControllerElementIdentifier> ButtonElementIdentifiers { get; } // 0x0000000185E83E50-0x0000000185E83F70 
		public IList<IControllerTemplate> Templates { get; } // 0x0000000185E84050-0x0000000185E84160 
		public int templateCount { get; } // 0x0000000185E84BA0-0x0000000185E84CB0 
		internal static Func<Controller, System.Type, bool> implementsTemplateDelegate_Type { get; } // 0x0000000185E847D0-0x0000000185E848D0 
	
		// Events
		internal event Action<bool> EnabledStateChangedEvent;
	
		// Nested types
		public abstract class Element // TypeDefIndex: 3621
		{
			// Fields
			public readonly int id; // 0x10
			public readonly string name; // 0x18
			public readonly ControllerElementType type; // 0x20
			internal yOeRxsEVwDQrznDqivHTAGFIhIKi RZMvlrDreIsgIkkLWnqvppfvSXS; // 0x28
			internal int axHEQbAmdnNnSAAeBbHMhcbvfuTu; // 0x30
			internal Controller HUdfNKdOgxfoxjMZAKUlkQYPszXh; // 0x38
			internal readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x40
	
			// Properties
			public ControllerElementIdentifier elementIdentifier { get; } // 0x0000000185E89AC0-0x0000000185E89BB0 
			public bool isMemberElement { get; } // 0x0000000185E89BB0-0x0000000185E89C80 
	
			// Nested types
			internal abstract class yOeRxsEVwDQrznDqivHTAGFIhIKi // TypeDefIndex: 3622
			{
				// Fields
				protected readonly int WpAeooJslwObDnzcpAZAXnTbzXMk; // 0x10
				protected readonly int[] CHoRXFaiXpGXafiYeDBMIipZWCo; // 0x18
				protected GzQFDjITTZzuJjzlwnZURJKfaTxW[] gRSZlsGnOMePzdfqhIobycvdjXwm; // 0x20
				public GzQFDjITTZzuJjzlwnZURJKfaTxW xbRrcEKKIAKiQkVzQCekOswVHrJ; // 0x28
				private int RMmuzLwPyyqjZzFkavzjXDLDVyZ; // 0x30
				public int ZMZbecCGBpEGMhMVXcfFEAvXLKW; // 0x34
				protected ReadOnlyCollection<GzQFDjITTZzuJjzlwnZURJKfaTxW> OQRxKYktpyefzhhnCyUgIPGjMMn; // 0x38
	
				// Properties
				public IList<GzQFDjITTZzuJjzlwnZURJKfaTxW> oEzmuuHgBhdjFiEcpamwisyAtXmv { get; } // 0x0000000185E969F0-0x0000000185E96A50 
				public UpdateLoopType uZqPISCyPgGPOetNKiFUKtuJqjV { get; set; } // 0x0000000185E96A50-0x0000000185E96B20
	
				// Nested types
				public abstract class GzQFDjITTZzuJjzlwnZURJKfaTxW // TypeDefIndex: 3623
				{
					// Constructors
					protected GzQFDjITTZzuJjzlwnZURJKfaTxW() {} // 0x0000000185E8A260-0x0000000185E8A2C0
	
					// Methods
					public abstract void Reset();
				}
	
				// Constructors
				protected yOeRxsEVwDQrznDqivHTAGFIhIKi() {} // Dummy constructor
				public yOeRxsEVwDQrznDqivHTAGFIhIKi(UpdateLoopSetting updateLoopSetting) {} // 0x0000000185E96780-0x0000000185E969F0
	
				// Methods
				public void EEGiMNPSMElaPgKQdmScoWLedfb() {} // 0x0000000185E966A0-0x0000000185E96780
			}
	
			// Constructors
			protected Element() {} // Dummy constructor
			internal Element(Controller controller, int elementIdentifierId, string name, ControllerElementType type) {} // 0x0000000185E89A00-0x0000000185E89AC0
	
			// Methods
			public void Reset() {} // 0x0000000185E89860-0x0000000185E89970
			internal void RgsMWPoTvBToOeodGAJsakxJpBT() {} // 0x0000000185E89970-0x0000000185E89A00
		}
	
		public sealed class Axis : Element // TypeDefIndex: 3624
		{
			// Fields
			internal readonly AxisRange GsnVEUNrADoUdYdWxqJZnmbrmhn; // 0x48
			internal readonly HardwareAxisInfo flIXmRKXOUURLlZiHjZlJLbgGru; // 0x50
	
			// Properties
			public float value { get => default; } // 0x0000000185E6FB30-0x0000000185E6FC90 
			public float valuePrev { get => default; } // 0x0000000185E6F780-0x0000000185E6F8E0 
			public float valueRaw { get => default; internal set {} } // 0x0000000185E6F9F0-0x0000000185E6FB30 0x0000000185E6FD40-0x0000000185E6FE70
			public float valueRawPrev { get => default; } // 0x0000000185E6F8E0-0x0000000185E6F9F0 
			public float valueDelta { get => default; } // 0x0000000185E6F690-0x0000000185E6F780 
			public float valueDeltaRaw { get => default; } // 0x0000000185E6F530-0x0000000185E6F690 
			public float lastTimeActive { get => default; } // 0x0000000185E6EB60-0x0000000185E6EC70 
			public float lastTimeActiveRaw { get => default; } // 0x0000000185E6EA20-0x0000000185E6EB60 
			public float lastTimeInactive { get => default; } // 0x0000000185E6ED80-0x0000000185E6EE90 
			public float lastTimeInactiveRaw { get => default; } // 0x0000000185E6EC70-0x0000000185E6ED80 
			public float lastTimeValueChanged { get => default; } // 0x0000000185E6EFA0-0x0000000185E6F0B0 
			public float lastTimeValueChangedRaw { get => default; } // 0x0000000185E6EE90-0x0000000185E6EFA0 
			public float timeActive { get => default; } // 0x0000000185E6F1D0-0x0000000185E6F2F0 
			public float timeActiveRaw { get => default; } // 0x0000000185E6F0B0-0x0000000185E6F1D0 
			public float timeInactive { get => default; } // 0x0000000185E6F410-0x0000000185E6F530 
			public float timeInactiveRaw { get => default; } // 0x0000000185E6F2F0-0x0000000185E6F410 
	
			// Nested types
			internal class jImLqlIVbHlDfdiDAmjwHUvcTqt : Element.yOeRxsEVwDQrznDqivHTAGFIhIKi // TypeDefIndex: 3625
			{
				// Nested types
				public class ZczptBVwSKbyiWpvXbYeBmDzhcD : Element.yOeRxsEVwDQrznDqivHTAGFIhIKi.GzQFDjITTZzuJjzlwnZURJKfaTxW // TypeDefIndex: 3626
				{
					// Fields
					public float JHgsNLxiAQVnmyfVeWejfTJocIu; // 0x10
					public float NckTuqeNamazETPgRISbxBNlOkT; // 0x14
					public float DSUWIZhLGdAGFywJbXfvRFVTiKZ; // 0x18
					public float cJLvXtACONCPFglEwCWxbHqdeE; // 0x1C
					public float sorsfJzEsCsMfauCVygigBCKqOQ; // 0x20
					public float FbCBMtFFQVcRgNXOHRusLFeBSEDi; // 0x24
					public float aPoeXomShorTvZjdXQtRuGVVtPw; // 0x28
					public float KoQZReOknbBHwfCaBXDlGZmaFWQa; // 0x2C
					public float DJiDfjiFQgxNhsvLZYAQfdDkDrm; // 0x30
					public float LRpVSpNPLWRGcutWqjzZZwcuVOj; // 0x34
					public float eNlfaOWiskAoBeDZqhqqUAabphnq; // 0x38
					public float gbdAwShoXxIelgOSWgWwtrwBExL; // 0x3C
	
					// Properties
					public float yOwzAKsuNZgZCKxYyerKTuJNbKR { get => default; } // 0x0000000185E947E0-0x0000000185E94890 
					public float sKIIWWTCZsXoMtaQbZLpodhAfMu { get => default; } // 0x0000000185E94940-0x0000000185E949F0 
					public float GZlQkzlmTaUQrXaHwbPsfTgXefLz { get => default; } // 0x0000000185E94890-0x0000000185E94940 
	
					// Constructors
					public ZczptBVwSKbyiWpvXbYeBmDzhcD() {} // 0x0000000185E94740-0x0000000185E947E0
	
					// Methods
					public void UZSQFwoMfSAzsmmSKmseCCiJWWD(bool param_00007fa8) {} // 0x0000000185E944E0-0x0000000185E94740
					public void iDuFvOcgOBRwUXteGwXQgTGoKUL(float param_00007fa9) {} // 0x0000000185E949F0-0x0000000185E94AA0
					public override void Reset() {} // 0x0000000185E94410-0x0000000185E944E0
				}
	
				// Constructors
				public jImLqlIVbHlDfdiDAmjwHUvcTqt() {} // Dummy constructor
				public jImLqlIVbHlDfdiDAmjwHUvcTqt(UpdateLoopSetting updateCycle) {} // 0x0000000185E95400-0x0000000185E95530
			}
	
			// Constructors
			public Axis() {} // Dummy constructor
			internal Axis(Controller controller, int elementIdentifierId, string name, AxisRange axisRange, HardwareAxisInfo axisInfo) {} // 0x0000000185E6E810-0x0000000185E6E930
	
			// Methods
			internal void SRMdBdXlvvGwaVElVdmvHLQdODs(float param_00007f9d) {} // 0x0000000185E6E6F0-0x0000000185E6E810
			internal void hFZfconneSNSSDboIpZxIrDbEKL(UpdateLoopType param_00007fa3) {} // 0x0000000185E6FC90-0x0000000185E6FD40
			internal void KZaWnSfEanREcjXdiSEBKrZinBA(AxisCalibration param_00007fa4) {} // 0x0000000185E6E450-0x0000000185E6E610
			internal void KZaWnSfEanREcjXdiSEBKrZinBA() {} // 0x0000000185E6E610-0x0000000185E6E6F0
			internal void xqneffBvtliTsIbgjcfZhJdKvLbg() {} // 0x0000000185E6FE70-0x0000000185E6FF50
			internal void fcTFDEZsXDBrgfytqUGSCWrjjSq() {} // 0x0000000185E6E930-0x0000000185E6EA20
			internal float EiHIbOkFnjiOtBqrPpxWNhaRfUYA(UpdateLoopType param_00007fa5, AxisCalibration param_00007fa6) => default; // 0x0000000185E6E230-0x0000000185E6E450
		}
	
		public sealed class Button : Element // TypeDefIndex: 3627
		{
			// Fields
			internal readonly bool EOEuEHUjrfDrsgyreIyiycBWacU; // 0x48
			internal readonly HardwareButtonInfo HeWnhSDeUwBpzVKMyfPgtPmfjjx; // 0x50
	
			// Properties
			public bool valuePrev { get => default; } // 0x0000000185E71A60-0x0000000185E71B60 
			public bool value { get => default; } // 0x0000000185E71B60-0x0000000185E71C60 
			public float pressure { get => default; } // 0x0000000185E715A0-0x0000000185E71700 
			public float pressurePrev { get => default; } // 0x0000000185E71440-0x0000000185E715A0 
			public bool isPressureSensitive { get => default; } // 0x0000000185E70C10-0x0000000185E70D10 
			public bool justPressed { get => default; } // 0x0000000185E70E40-0x0000000185E70F90 
			public bool justReleased { get => default; } // 0x0000000185E70F90-0x0000000185E710E0 
			public bool doublePressedAndHeld { get => default; } // 0x0000000185E70AF0-0x0000000185E70C10 
			public bool justDoublePressed { get => default; } // 0x0000000185E70D10-0x0000000185E70E40 
			public float timePressed { get => default; } // 0x0000000185E71820-0x0000000185E71940 
			public float timeUnpressed { get => default; } // 0x0000000185E71940-0x0000000185E71A60 
			public float lastTimePressed { get => default; } // 0x0000000185E710E0-0x0000000185E71200 
			public float lastTimeUnpressed { get => default; } // 0x0000000185E71320-0x0000000185E71440 
			public float lastTimeStateChanged { get => default; } // 0x0000000185E71200-0x0000000185E71320 
			internal ButtonStateFlags state { get => default; } // 0x0000000185E71700-0x0000000185E71820 
	
			// Nested types
			internal class yjhRtkIzVXSQVfVwvLIPjqbChn : Element.yOeRxsEVwDQrznDqivHTAGFIhIKi // TypeDefIndex: 3628
			{
				// Nested types
				public class RrGVlGygLARrWGUtVGJMxebrZHM : Element.yOeRxsEVwDQrznDqivHTAGFIhIKi.GzQFDjITTZzuJjzlwnZURJKfaTxW // TypeDefIndex: 3629
				{
					// Fields
					public bool JHgsNLxiAQVnmyfVeWejfTJocIu; // 0x10
					public bool NckTuqeNamazETPgRISbxBNlOkT; // 0x11
					public ButtonStateRecorder RckdEjtDroWEnGIzFfcLMuRYwMw; // 0x18
					public tjVSzgCpYulTxiHPuJpvoyKcuuZ WZaxCprIxlokEfqunzmAuhgUFym; // 0x20
	
					// Constructors
					public RrGVlGygLARrWGUtVGJMxebrZHM() {} // 0x0000000185E92020-0x0000000185E92140
	
					// Methods
					public void MPPQJfVkqEnvckKDMacDSmlvhjwB(bool param_00007fb5) {} // 0x0000000185E91DD0-0x0000000185E91F90
					public override void Reset() {} // 0x0000000185E91F90-0x0000000185E92020
				}
	
				public class ADQauUEAuNSWJKGRcZVfdnHdgeKJ : RrGVlGygLARrWGUtVGJMxebrZHM // TypeDefIndex: 3630
				{
					// Fields
					public float kBUagekNtysluoUQKtUuHIlTPLF; // 0x28
					public float LXHwmFBzbUAeMBVkPkSEWXhQJuz; // 0x2C
	
					// Constructors
					public ADQauUEAuNSWJKGRcZVfdnHdgeKJ() {} // 0x0000000185E6DA50-0x0000000185E6DAB0
	
					// Methods
					public void MPPQJfVkqEnvckKDMacDSmlvhjwB(float param_00007fb6) {} // 0x0000000185E6D8F0-0x0000000185E6D9E0
					public override void Reset() {} // 0x0000000185E6D9E0-0x0000000185E6DA50
				}
	
				// Constructors
				public yjhRtkIzVXSQVfVwvLIPjqbChn() {} // Dummy constructor
				public yjhRtkIzVXSQVfVwvLIPjqbChn(UpdateLoopSetting updateCycle, bool isPressureSensitive) {} // 0x0000000185E96B20-0x0000000185E96C90
			}
	
			// Constructors
			public Button() {} // Dummy constructor
			internal Button(Controller controller, int elementIdentifierId, string name, bool isPressureSensitive, HardwareButtonInfo buttonInfo) {} // 0x0000000185E709E0-0x0000000185E70AF0
	
			// Methods
			internal void MPPQJfVkqEnvckKDMacDSmlvhjwB(UpdateLoopType param_00007faf, int param_00007fb0, ControllerDataUpdater param_00007fb1) {} // 0x0000000185E70320-0x0000000185E70610
			internal void TyrDDJAfnnLNoDKHAjBmQpKiHMBc(UpdateLoopType param_00007fb2) {} // 0x0000000185E70610-0x0000000185E709E0
		}
	
		public abstract class CompoundElement // TypeDefIndex: 3631
		{
			// Fields
			private int wyOUtAQIXRMHfdYotPsXMPVUbwu; // 0x10
			private string EqppaAHmTQvmVSSZadzlNpPBbHM; // 0x18
			private CompoundControllerElementType iaFziOmGetWMviBsUmpNhLnTJKt; // 0x20
			private int MyNJRXLJmKCNcpkEAMoRJKKLEAYf; // 0x24
			private hYKOpwfgGmkXWecqWzTZUllYVvP[] PvbfvGDQstrrExqmLGQWIcGWljDB; // 0x28
			private Controller HUdfNKdOgxfoxjMZAKUlkQYPszXh; // 0x30
			internal readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x38
	
			// Properties
			public abstract int elementCapacity { get; }
	
			// Nested types
			private class hYKOpwfgGmkXWecqWzTZUllYVvP // TypeDefIndex: 3632
			{
				// Fields
				public readonly Element nsrJcOgpcFdFnRaSgBMVkSZUgdlg; // 0x10
				public readonly int GFxMtMQcTztHIzUiZNyflMJzBUL; // 0x18
	
				// Constructors
				public hYKOpwfgGmkXWecqWzTZUllYVvP() {} // Dummy constructor
				public hYKOpwfgGmkXWecqWzTZUllYVvP(Element element, int elementIndex) {} // 0x0000000185E95310-0x0000000185E95390
			}
	
			// Constructors
			protected CompoundElement() {} // Dummy constructor
			internal CompoundElement(Controller controller, int elementIdentifierId, string name, CompoundControllerElementType type) {} // 0x0000000185E71F20-0x0000000185E72010
	
			// Methods
			internal T KQaqMptOrhHmGWOCKcwibHIHaLV<T>(int param_00007fbb)
				where T : Element => default;
			internal T YpssoAuWXtTjMJWSPmeVOHKAbIS<T>(int param_00007fbc, out int param_00007fbd)
				where T : Element {
				param_00007fbd = default;
				return default;
			}
			internal bool uiIyqEcLjeCLLGNLkqHYomAmAGZF(Element param_00007fbe, int param_00007fbf) => default; // 0x0000000185E72010-0x0000000185E72140
			private int PPScODKITNkJhuhwQPXehuNrLBk(Element param_00007fc0) => default; // 0x0000000185E71C60-0x0000000185E71DB0
			private bool RFtOjArFZkPeFKLQKcDShGpkeyC(Element param_00007fc1, int param_00007fc2, int param_00007fc3) => default; // 0x0000000185E71DB0-0x0000000185E71F20
			private int zKyiZnmWaZByvHQigwwWtDsrVTu() => default; // 0x0000000185E72140-0x0000000185E72230
		}
	
		public sealed class Axis2D : CompoundElement // TypeDefIndex: 3633
		{
			// Fields
			private const int AnuAPEGHwjlThBSXexpecstXnIxJ = 2; // Metadata: 0x00AC40D9
			private CalibrationMap pDUFIxrVjvLRhJUpupZLHCRAZAw; // 0x40
	
			// Properties
			public override int elementCapacity { get => default; } // 0x0000000185E6DC80-0x0000000185E6DCD0 
			public Axis xAxis { get => default; } // 0x0000000185E6DDD0-0x0000000185E6DEE0 
			public Axis yAxis { get => default; } // 0x0000000185E6DEE0-0x0000000185E6DFC0 
			public Vector2 value { get => default; } // 0x0000000185E6DCD0-0x0000000185E6DDD0 
	
			// Constructors
			public Axis2D() {} // Dummy constructor
			internal Axis2D(Controller controller, int elementIdentifierId, string name, Axis xAxis, Axis yAxis, int xAxisIndex, int yAxisIndex, CalibrationMap calibratonMap) {} // 0x0000000185E6DAB0-0x0000000185E6DB80
	
			// Methods
			internal void dvtavmcwhNkMVmvvKqcPhKMHyKbP() {} // 0x0000000185E6DB80-0x0000000185E6DC80
			private Vector2 wehVXwIAssIoIGOesrwSJhimQTA() => default; // 0x0000000185E6DFC0-0x0000000185E6E1C0
		}
	
		public sealed class Hat : CompoundElement // TypeDefIndex: 3634
		{
			// Fields
			private const int AnuAPEGHwjlThBSXexpecstXnIxJ = 8; // Metadata: 0x00AC40DD
			private const int vVskJthRmqBKAuXrgeQpIMzypRA = 0; // Metadata: 0x00AC40E1
			private const int AYmqAOYhoKakXulFWzKerteGUqf = 1; // Metadata: 0x00AC40E5
			private const int vLdCWtaeXLEAAwQliybjIIuNlzjG = 2; // Metadata: 0x00AC40E9
			private const int INbatWaACfEmGDDKeMTDoOupuCV = 3; // Metadata: 0x00AC40ED
			private const int reLEiMYznOWsfjhwaNgVcOgsnIv = 4; // Metadata: 0x00AC40F1
			private const int zlVSDhidmfdsRDJmZjoIAxMheEp = 5; // Metadata: 0x00AC40F5
			private const int btbxfMygkbJkhBfpSGZOZLELTbRq = 6; // Metadata: 0x00AC40F9
			private const int YzNteTtGAPlbtHncrLPzCPAISax = 7; // Metadata: 0x00AC40FD
			private readonly int jWRCMWQrEgSaEEOkwnKCQeiQjUVe; // 0x40
			private readonly Button[] lgAkyeKCNYSjxkICDjzKgIcrtWEL; // 0x48
			private readonly ReadOnlyCollection<Button> WqMuliDVbBodofWEcnJDpNauibo; // 0x50
			private readonly int[] DDlECKKfaAmhmrNTFAvDdmrAUQU; // 0x58
			private bool lOufpFCMmWjtVefrHLjOAFxPJGvz; // 0x60
	
			// Properties
			public override int elementCapacity { get => default; } // 0x0000000185E8B260-0x0000000185E8B2B0 
	
			// Constructors
			public Hat() {} // Dummy constructor
			internal Hat(Controller controller, int elementIdentifierId, string name, Button[] buttons, int[] buttonIndices) {} // 0x0000000185E8A850-0x0000000185E8AB00
	
			// Methods
			internal void dvtavmcwhNkMVmvvKqcPhKMHyKbP(UpdateLoopType param_00007fd3, ControllerDataUpdater param_00007fd4) {} // 0x0000000185E8AB00-0x0000000185E8B260
			private void IqwHADcrSWkZANagIvQfueChdEF(Button param_00007fd5, int param_00007fd6, int param_00007fd7, int param_00007fd8, UpdateLoopType param_00007fd9, ControllerDataUpdater param_00007fda) {} // 0x0000000185E8A2C0-0x0000000185E8A690
			private void RdgbRTCoKbHOBpzYqnfNLaGHfyuP(Button param_00007fdb, int param_00007fdc, UpdateLoopType param_00007fdd, ControllerDataUpdater param_00007fde) {} // 0x0000000185E8A690-0x0000000185E8A850
		}
	
		[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
		public abstract class Extension // TypeDefIndex: 3635
		{
			// Fields
			private Controller HUdfNKdOgxfoxjMZAKUlkQYPszXh; // 0x10
			private IControllerExtensionSource PESlCqcuFEdCgwfIyyIoKbUwani; // 0x18
			internal readonly int _reInputId; // 0x20
	
			// Properties
			internal bool isJoystickConnected { get; } // 0x0000000185E8A100-0x0000000185E8A170 
			internal bool enabled { get; } // 0x0000000185E8A090-0x0000000185E8A100 
	
			// Constructors
			protected Extension() {} // Dummy constructor
			internal Extension(IControllerExtensionSource source) {} // 0x0000000185E89F70-0x0000000185E8A090
			internal Extension(Extension source) {} // 0x0000000185E89EE0-0x0000000185E89F70
	
			// Methods
			internal T GetController<T>()
				where T : Controller => default;
			internal void SetController(Controller controller) {} // 0x0000000185E89DA0-0x0000000185E89E00
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal IControllerExtensionSource GetSource() => default; // 0x0000000185E89D40-0x0000000185E89DA0
			internal void SetSource(Extension extension) {} // 0x0000000185E89E00-0x0000000185E89EE0
			private void xxivCgrJRpzIZUrpFPBIsrhTFQR(IControllerExtensionSource param_00007fe3) {} // 0x0000000185E8A170-0x0000000185E8A1F0
			internal virtual void Clear() {} // 0x0000000185E89CF0-0x0000000185E89D40
			internal abstract void SourceUpdated(IControllerExtensionSource source);
			internal abstract void UpdateData(UpdateLoopType updateLoop);
			internal abstract Extension Clone();
		}
	
		// Constructors
		protected Controller() {} // Dummy constructor
		internal Controller(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, bool[] isButtonPressureSensitive, HardwareButtonInfo[] hwButtonInfo, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater) {} // 0x0000000185E837A0-0x0000000185E83DA0
	
		// Methods
		internal virtual void snpHjGkGVogejiySyWIFjoJWDLTS() {} // 0x0000000185E85270-0x0000000185E85320
		public virtual Element GetElementById(int elementIdentifierId) => default; // 0x0000000185E82470-0x0000000185E82590
		public int GetButtonIndexById(int elementIdentifierId) => default; // 0x0000000185E82240-0x0000000185E82330
		public ControllerElementIdentifier GetElementIdentifierById(int elementIdentifierId) => default; // 0x0000000185E82590-0x0000000185E826B0
		public virtual bool GetButton(int index) => default; // 0x0000000185E82330-0x0000000185E82470
		public virtual bool GetAnyButtonDown() => default; // 0x0000000185E820D0-0x0000000185E82240
		public virtual IEnumerable<ControllerPollingInfo> PollForAllElementsDown() => default; // 0x0000000185E82F50-0x0000000185E82FC0
		public virtual IEnumerable<ControllerPollingInfo> PollForAllButtonsDown() => default; // 0x0000000185E82E90-0x0000000185E82F50
		private bool VkYPMFlzGbqTcwGAGUFPygZuyLN(int param_00007f7d, out int param_00007f7e) {
			param_00007f7e = default;
			return default;
		} // 0x0000000185E835A0-0x0000000185E83710
		protected void UpdatePollingFrameTracking() {} // 0x0000000185E833D0-0x0000000185E835A0
		public virtual float GetLastTimeAnyElementChanged() => default; // 0x0000000185E82970-0x0000000185E82A60
		public virtual float GetLastTimeAnyElementChanged(bool useRawValues) => default; // 0x0000000185E82890-0x0000000185E82970
		public float GetLastTimeAnyButtonChanged() => default; // 0x0000000185E826B0-0x0000000185E82890
		public T GetExtension<T>()
			where T : class => default;
		public T GetTemplate<T>()
			where T : class => default;
		public bool ImplementsTemplate(Guid typeGuid) => default; // 0x0000000185E82C40-0x0000000185E82E90
		public bool ImplementsTemplate(System.Type type) => default; // 0x0000000185E82A60-0x0000000185E82C40
		internal void vRVgKtnyYDgVtYmVZcPHYjYJKvu(IControllerTemplate[] param_00007f82) {} // 0x0000000185E853A0-0x0000000185E85480
		internal virtual void UpdateData(UpdateLoopType param_00007f83) {} // 0x0000000185E830C0-0x0000000185E833D0
		internal virtual ButtonStateFlags wJMDqzalTAkbVUNADdKHbMgQhGiP(int param_00007f84) => default; // 0x0000000185E855D0-0x0000000185E85690
		internal void qVYVNupolNeIsaFeJRsbUHVXuxRg(Extension param_00007f85) {} // 0x0000000185E84E20-0x0000000185E84F70
		internal void wFNxILHosqnCwEOlbeICtkHZvYR(Extension param_00007f86) {} // 0x0000000185E85480-0x0000000185E855D0
		internal virtual void Clear() {} // 0x0000000185E81E50-0x0000000185E81FD0
		internal virtual bool SetEnabled(bool param_00007f87) => default; // 0x0000000185E82FC0-0x0000000185E830C0
		internal virtual void BakeMap(ControllerMap param_00007f88) {} // 0x0000000185E81CB0-0x0000000185E81E50
		internal virtual void BakeActionElementMap(ControllerMap param_00007f89, ActionElementMap param_00007f8a) {} // 0x0000000185E81C10-0x0000000185E81CB0
		internal bool zipcKsFwwhgorhescWUPdkTTOFi(ActionElementMap param_00007f8b, int param_00007f8c, out float param_00007f8d, out bool param_00007f8e) {
			param_00007f8d = default;
			param_00007f8e = default;
			return default;
		} // 0x0000000185E85690-0x0000000185E85980
		internal bool zipcKsFwwhgorhescWUPdkTTOFi(ActionElementMap param_00007f8f, int param_00007f90, bool param_00007f91, out float param_00007f92) {
			param_00007f92 = default;
			return default;
		} // 0x0000000185E85980-0x0000000185E85B20
		internal void uiIyqEcLjeCLLGNLkqHYomAmAGZF(Element param_00007f93) {} // 0x0000000185E85320-0x0000000185E853A0
		protected virtual void Connected() {} // 0x0000000185E81FD0-0x0000000185E82030
		protected virtual void Disconnected() {} // 0x0000000185E82030-0x0000000185E820D0
	}
}
