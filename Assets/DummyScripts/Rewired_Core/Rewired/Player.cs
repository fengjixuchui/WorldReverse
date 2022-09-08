/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;
using Rewired.Utils.Classes;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class Player // TypeDefIndex: 4199
	{
		// Fields
		private readonly GDZJmMlQvBAxDaQCuBIKYWggay QCTuKaMpAGgTtcQyTPDDesuJWwyb; // 0x10
		private bool wzliHwkSqsqXnuzcrItlnGosEFK; // 0x18
		private int rOuBUzbbciWwktcpmiPWpQIKoaAa; // 0x1C
		private string EqppaAHmTQvmVSSZadzlNpPBbHM; // 0x20
		private string fcDWHDMixsdgtWlJzlVakRjRCGy; // 0x28
		private bool BMqYVQTBOGkiqBwYdORkfmZYOzj; // 0x30
		private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x34
		public readonly ControllerHelper controllers; // 0x38
	
		// Properties
		public int id { get => default; } // 0x0000000185BE6BD0-0x0000000185BE6CA0 
		public string name { get => default; } // 0x0000000185BE6D70-0x0000000185BE6E90 
		public string descriptiveName { get => default; } // 0x0000000185BE6AD0-0x0000000185BE6BD0 
		public bool isPlaying { get => default; set {} } // 0x0000000185BE6CA0-0x0000000185BE6D70 0x0000000185BE6E90-0x0000000185BE6EF0
	
		// Nested types
		// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
		// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
		public sealed class ControllerHelper // TypeDefIndex: 4200
		{
			// Fields
			private readonly spKjefQHmxNxJzZamklJqnpngzC sMzIVQFOeXYGuLChRdbKaGGSIAYG; // 0x10
			private bool ZhqzVJqCREpERcvVPtMKderstPu; // 0x18
			private bool wwqcZFmuzrEiBNgQhdtufjHtcdsT; // 0x19
			private bool DMdGPQxTJQlyzeyuYGVEIhRbEDw; // 0x1A
			private float xApUtBGxBbXmauApwwNPOWDIRWu; // 0x1C
			private float jfTZIvRJDUPOYfosphffseQhgSMa; // 0x20
			private SafeAction<ControllerAssignmentChangedEventArgs> rpanRUiyKVDOdHJtLGdbjwWAsDgO; // 0x28
			private SafeAction<ControllerAssignmentChangedEventArgs> kgQSKLVZFhkUKBGJedKizFUtqBR; // 0x30
			private readonly lXvHoEyUvLMAAFqiBbrfAziZrSiB VYIiPbQDTfmyzeeKLOEXjAUgGAe; // 0x38
			private readonly Player sKXWHubnVhxWhOxTHOuVspOItdX; // 0x40
			private readonly COUAbpKeuXqLvBpbzwQGcJgjPueY VdYbRIfIAqVYCJnTMRUdCcFYmUp; // 0x48
			private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x50
			public readonly MapHelper maps; // 0x58
			public readonly ConflictCheckingHelper conflictChecking; // 0x60
			public readonly PollingHelper polling; // 0x68
	
			// Properties
			private gvufEBygcUrXysEJzvawCPbsDrxh<Joystick, JoystickMap> joystickSet { get => default; } // 0x0000000185BD1AF0-0x0000000185BD1B90 
			private CbjrqLOJCueoJWGbtJskOtJnHIE<KeyboardMap> keyboardMapSet { get => default; } // 0x0000000185BD1B90-0x0000000185BD1CD0 
			private CbjrqLOJCueoJWGbtJskOtJnHIE<MouseMap> mouseMapSet { get => default; } // 0x0000000185BD1CD0-0x0000000185BD1E20 
			private gvufEBygcUrXysEJzvawCPbsDrxh<CustomController, CustomControllerMap> customControllerSet { get => default; } // 0x0000000185BD16E0-0x0000000185BD1780 
			public bool hasMouse { get => default; set {} } // 0x0000000185BD1920-0x0000000185BD19F0 0x0000000185BD2460-0x0000000185BD2890
			public bool hasKeyboard { get => default; set {} } // 0x0000000185BD1850-0x0000000185BD1920 0x0000000185BD2080-0x0000000185BD2460
			public bool excludeFromControllerAutoAssignment { get => default; set {} } // 0x0000000185BD1780-0x0000000185BD1850 0x0000000185BD1FB0-0x0000000185BD2080
			public Keyboard Keyboard { get => default; } // 0x0000000185BD1400-0x0000000185BD14F0 
			public Mouse Mouse { get => default; } // 0x0000000185BD14F0-0x0000000185BD15E0 
			public int joystickCount { get => default; } // 0x0000000185BD19F0-0x0000000185BD1AF0 
			public IList<Joystick> Joysticks { get => default; } // 0x0000000185BD12E0-0x0000000185BD1400 
			public int customControllerCount { get => default; } // 0x0000000185BD15E0-0x0000000185BD16E0 
			public IList<CustomController> CustomControllers { get => default; } // 0x0000000185BD11C0-0x0000000185BD12E0 
			public IEnumerable<Controller> Controllers { get => default; } // 0x0000000185BD1100-0x0000000185BD11C0 
	
			// Nested types
			// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
			// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
			public sealed class ConflictCheckingHelper : CodeHelper // TypeDefIndex: 4201
			{
				// Fields
				private readonly Player sKXWHubnVhxWhOxTHOuVspOItdX; // 0x10
				private readonly ControllerHelper GXjksnimfWszjuquGUzFlFpJFosa; // 0x18
				private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x20
	
				// Constructors
				public ConflictCheckingHelper() {} // Dummy constructor
				internal ConflictCheckingHelper(Player player, ControllerHelper parent) {} // 0x0000000185BCB6F0-0x0000000185BCB7A0
	
				// Methods
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck) => default; // 0x0000000185BCA0F0-0x0000000185BCA1B0
				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) => default; // 0x0000000185BC9E30-0x0000000185BCA0F0
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) => default; // 0x0000000185BCA450-0x0000000185BCA510
				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) => default; // 0x0000000185BCA1B0-0x0000000185BCA450
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) => default; // 0x0000000185BCAE50-0x0000000185BCAF10
				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps, bool forceCheckAllCategories) => default; // 0x0000000185BCAF10-0x0000000185BCB1A0
				private bool NyFuxfADTrTtpiMcPjOyAHMxmgJC(ElementAssignmentConflictCheck param_00008bd2, bool param_00008bd3 = false /* Metadata: 0x00AC4D21 */, bool param_00008bd4 = false /* Metadata: 0x00AC4D22 */) => default; // 0x0000000185BCAA10-0x0000000185BCAE50
				private bool sxbXPdWcQSPtIyQNmpExihqZMkN(ElementAssignmentConflictCheck param_00008bd5, bool param_00008bd6 = false /* Metadata: 0x00AC4D23 */, bool param_00008bd7 = false /* Metadata: 0x00AC4D24 */) => default; // 0x0000000185BCC4E0-0x0000000185BCC620
				private bool sRIembgFXeKViNeDybIEmhBtegkP(ElementAssignmentConflictCheck param_00008bd8, bool param_00008bd9 = false /* Metadata: 0x00AC4D25 */, bool param_00008bda = false /* Metadata: 0x00AC4D26 */) => default; // 0x0000000185BCC260-0x0000000185BCC3A0
				private bool VeceKxEjcOYRAQkmZSAYjURbWiu(ElementAssignmentConflictCheck param_00008bdb, bool param_00008bdc = false /* Metadata: 0x00AC4D27 */, bool param_00008bdd = false /* Metadata: 0x00AC4D28 */) => default; // 0x0000000185BCB2A0-0x0000000185BCB6F0
				private IEnumerable<ElementAssignmentConflictInfo> UvfOKWFEbJnWdIbkfyQfwTUNyAq(ElementAssignmentConflictCheck param_00008bde, bool param_00008bdf = false /* Metadata: 0x00AC4D29 */, bool param_00008be0 = false /* Metadata: 0x00AC4D2A */) => default; // 0x0000000185BCB1A0-0x0000000185BCB2A0
				private IEnumerable<ElementAssignmentConflictInfo> bVWdjiSGMfZhKRdfwDXfGWJJssle(ElementAssignmentConflictCheck param_00008be1, bool param_00008be2 = false /* Metadata: 0x00AC4D2B */, bool param_00008be3 = false /* Metadata: 0x00AC4D2C */) => default; // 0x0000000185BCB7A0-0x0000000185BCB900
				private IEnumerable<ElementAssignmentConflictInfo> KrmTdddPXiviaOBrykoGFHHWvHn(ElementAssignmentConflictCheck param_00008be4, bool param_00008be5 = false /* Metadata: 0x00AC4D2D */, bool param_00008be6 = false /* Metadata: 0x00AC4D2E */) => default; // 0x0000000185BCA510-0x0000000185BCA670
				private IEnumerable<ElementAssignmentConflictInfo> fauxUnTqcoOCTubOefVVEudwnILH(ElementAssignmentConflictCheck param_00008be7, bool param_00008be8 = false /* Metadata: 0x00AC4D2F */, bool param_00008be9 = false /* Metadata: 0x00AC4D30 */) => default; // 0x0000000185BCB900-0x0000000185BCBA30
				private int fzhTnlMzuUvPLAhILxPkChCvaHL(ElementAssignmentConflictCheck param_00008bea, bool param_00008beb = false /* Metadata: 0x00AC4D31 */, bool param_00008bec = false /* Metadata: 0x00AC4D32 */) => default; // 0x0000000185BCBA30-0x0000000185BCBE70
				private int MnsQxCBBkiIQfpMlRhEwDEnchWjE(ElementAssignmentConflictCheck param_00008bed, bool param_00008bee = false /* Metadata: 0x00AC4D33 */, bool param_00008bef = false /* Metadata: 0x00AC4D34 */) => default; // 0x0000000185BCA8D0-0x0000000185BCAA10
				private int scWdmbsMfSzunfpvHAHTqWOXCEPb(ElementAssignmentConflictCheck param_00008bf0, bool param_00008bf1 = false /* Metadata: 0x00AC4D35 */, bool param_00008bf2 = false /* Metadata: 0x00AC4D36 */) => default; // 0x0000000185BCC3A0-0x0000000185BCC4E0
				private int sExJWcXPYZyRPVIoIVFXBiUTqjf(ElementAssignmentConflictCheck param_00008bf3, bool param_00008bf4 = false /* Metadata: 0x00AC4D37 */, bool param_00008bf5 = false /* Metadata: 0x00AC4D38 */) => default; // 0x0000000185BCBE70-0x0000000185BCC260
				private bool npVfUCIqggjlmSQJVCNnoBUIQAv<T>(ElementAssignmentConflictCheck param_00008bf6, bool param_00008bf7, bool param_00008bf8, CbjrqLOJCueoJWGbtJskOtJnHIE<T> param_00008bf9)
					where T : ControllerMap => default;
				private IEnumerable<ElementAssignmentConflictInfo> TORnWYUyHVnbHkdURBOQJVAEBXXU<T>(ElementAssignmentConflictCheck param_00008bfa, bool param_00008bfb, bool param_00008bfc, CbjrqLOJCueoJWGbtJskOtJnHIE<T> param_00008bfd)
					where T : ControllerMap => default;
				private int MjFvPEZFPxxVhhWkhAaMlHfemxf<T>(ElementAssignmentConflictCheck param_00008bfe, bool param_00008bff, bool param_00008c00, CbjrqLOJCueoJWGbtJskOtJnHIE<T> param_00008c01)
					where T : ControllerMap => default;
				private bool MMEpTnTKlRrbXZZnqqfPfMDpigW(InputMapCategory param_00008c02, ControllerMap param_00008c03) => default; // 0x0000000185BCA670-0x0000000185BCA8D0
			}
	
			internal interface kHMsYjJiKwOpoEpeOCPidxMTpkK // TypeDefIndex: 4205
			{
				// Properties
				vttCQucTsuPfaDyQDABPHDfiYb this[int index] { get => default; }
				ControllerType SlhgqMdZzgOWWmMwSscraDibqHK { get; }
				int GjxMqHiPMFWHbEAoireiwUjswOT { get; }
	
				// Methods
				bool Contains(int param_00008c08);
				void RemoveController(int param_00008c09);
				void RemoveAt(int param_00008c0a);
				Controller GetController(int param_00008c0b);
				Controller GetControllerWithTag(string param_00008c0c);
				int IndexOf(int param_00008c0d);
				void Clear();
				vttCQucTsuPfaDyQDABPHDfiYb GetEntry(int param_00008c0e);
				void AddEntry(vttCQucTsuPfaDyQDABPHDfiYb param_00008c0f);
			}
	
			internal interface vttCQucTsuPfaDyQDABPHDfiYb // TypeDefIndex: 4206
			{
				// Properties
				syapwIJQHBZeZRnKBfKyragYBFx jewfQedSyguEEkOXgxLUfzUvIZU { get; }
				Controller xwApvxwuWEivSrbItjIXHBzMlIz { get; }
				float SRthUgfOIAcVxeHhlOtToApszTsK { get; }
			}
	
			internal sealed class gvufEBygcUrXysEJzvawCPbsDrxh<TController, TMap> : kHMsYjJiKwOpoEpeOCPidxMTpkK // TypeDefIndex: 4207
				where TController : Controller
				where TMap : ControllerMap
			{
				// Fields
				private List<dpfuhxZWxUFWcsMwcfGsBIKlIAP> PvbfvGDQstrrExqmLGQWIcGWljDB;
				private List<TController> cePMrwbftknaPChwqTSQdPvGdlaK;
				private ReadOnlyCollection<TController> DyOBejoMZsLWKdrpcHSVbbEMEjT;
				private readonly ControllerType xRMUSowrwSVmfxjnqwQXevUgxsr;
	
				// Properties
				public int GjxMqHiPMFWHbEAoireiwUjswOT { get => default; }
				public IList<TController> ppHyNLFGrEwHDXqJbsYwCxfmaoJ { get => default; }
				public dpfuhxZWxUFWcsMwcfGsBIKlIAP this[int index] { get => default; }
				public ControllerType SlhgqMdZzgOWWmMwSscraDibqHK { get => default; }
				vttCQucTsuPfaDyQDABPHDfiYb this[int index] { get => default; }
	
				// Nested types
				public class dpfuhxZWxUFWcsMwcfGsBIKlIAP : vttCQucTsuPfaDyQDABPHDfiYb // TypeDefIndex: 4208
				{
					// Fields
					public TController xwApvxwuWEivSrbItjIXHBzMlIz;
					public CbjrqLOJCueoJWGbtJskOtJnHIE<TMap> jewfQedSyguEEkOXgxLUfzUvIZU;
					public float SRthUgfOIAcVxeHhlOtToApszTsK;
	
					// Properties
					Controller JoAriPKqKefLMAqoQxzJElxREFj { get => default; }
					syapwIJQHBZeZRnKBfKyragYBFx cAgiahJzWGMbLpUqSYfpsRrvryUg { get => default; }
					float InBVAekCRgWbtfrwryvMOaNFBYW { get => default; }
	
					// Constructors
					public dpfuhxZWxUFWcsMwcfGsBIKlIAP() {} // Dummy constructor
					public dpfuhxZWxUFWcsMwcfGsBIKlIAP(TController controller, CbjrqLOJCueoJWGbtJskOtJnHIE<TMap> mapSet) {}
	
					// Methods
					public void NkZydDENmorvpVrmCVfsQnRvDxL() {}
				}
	
				// Constructors
				public gvufEBygcUrXysEJzvawCPbsDrxh() {}
	
				// Methods
				public dpfuhxZWxUFWcsMwcfGsBIKlIAP aiHwPNekHXEhGGWjXNksfPnxocu(int param_00008c11) => default;
				public void emXobokVsAKXrnGPwrEfKyGypmk(dpfuhxZWxUFWcsMwcfGsBIKlIAP param_00008c12) {}
				public void RemoveController(int param_00008c13) {}
				public void RemoveAt(int param_00008c14) {}
				public TController lHAHnEiPErByQLPNWMxnJGMpiHF(int param_00008c15) => default;
				public bool Contains(int param_00008c16) => default;
				public int IndexOf(int param_00008c17) => default;
				public int IndexOfTag(string param_00008c18) => default;
				public void Clear() {}
				vttCQucTsuPfaDyQDABPHDfiYb Rewired.Player.ControllerHelper.IControllerSet.GetEntry(int param_00008c1a) => default;
				void Rewired.Player.ControllerHelper.IControllerSet.AddEntry(vttCQucTsuPfaDyQDABPHDfiYb param_00008c1b) {}
				Controller Rewired.Player.ControllerHelper.IControllerSet.GetController(int param_00008c1c) => default;
				Controller Rewired.Player.ControllerHelper.IControllerSet.GetControllerWithTag(string param_00008c1d) => default;
			}
	
			internal class spKjefQHmxNxJzZamklJqnpngzC // TypeDefIndex: 4209
			{
				// Fields
				public readonly int GjxMqHiPMFWHbEAoireiwUjswOT; // 0x10
				private ControllerType[] oSOEwWIKihxevVquLAbydFFycvs; // 0x18
				private kHMsYjJiKwOpoEpeOCPidxMTpkK[] HeDEduzNjKzgQDdJpbSQuRuwlZX; // 0x20
	
				// Constructors
				public spKjefQHmxNxJzZamklJqnpngzC() {} // Dummy constructor
				public spKjefQHmxNxJzZamklJqnpngzC(int length) {} // 0x0000000185BEFE40-0x0000000185BEFF40
	
				// Methods
				public kHMsYjJiKwOpoEpeOCPidxMTpkK VmMWmFTzlKiduQfgtuRJAUKiAtJ(int param_00008c20) => default; // 0x0000000185BEFDB0-0x0000000185BEFE40
				public ControllerType nuFYBhKFhdJtfgvexLaWkAQjrii(int param_00008c21) => default; // 0x0000000185BEFF40-0x0000000185BEFFD0
				public kHMsYjJiKwOpoEpeOCPidxMTpkK DSaFdqDaHtazMxrEgzJvIYlkcFrb(ControllerType param_00008c23) => default; // 0x0000000185BEFC70-0x0000000185BEFDB0
				public void uzFdVFBdHFJZfktjvFhVwFYmfMh(int param_00008c24, ControllerType param_00008c25, kHMsYjJiKwOpoEpeOCPidxMTpkK param_00008c26) {} // 0x0000000185BEFFD0-0x0000000185BF00D0
			}
	
			private class lXvHoEyUvLMAAFqiBbrfAziZrSiB // TypeDefIndex: 4210
			{
				// Fields
				private readonly List<lPNGZhakaXfqCCtJBxZfQNjmlTSa> rokTPxsNitEbJnvAHMxvBQpZKze; // 0x10
				private readonly Player sKXWHubnVhxWhOxTHOuVspOItdX; // 0x18
	
				// Nested types
				public class lPNGZhakaXfqCCtJBxZfQNjmlTSa // TypeDefIndex: 4211
				{
					// Fields
					public int WevTdQwnzmzGusLgYZijrubkIwX; // 0x10
					public CbjrqLOJCueoJWGbtJskOtJnHIE<JoystickMap> jewfQedSyguEEkOXgxLUfzUvIZU; // 0x18
					public float zQIbNGdnEQoZUIfuCdfWHLzkxFzJ; // 0x20
	
					// Constructors
					public lPNGZhakaXfqCCtJBxZfQNjmlTSa() {} // Dummy constructor
					public lPNGZhakaXfqCCtJBxZfQNjmlTSa(int joystickId, CbjrqLOJCueoJWGbtJskOtJnHIE<JoystickMap> mapSet, float lastConnectedTime) {} // 0x0000000185BEF520-0x0000000185BEF5C0
				}
	
				// Constructors
				public lXvHoEyUvLMAAFqiBbrfAziZrSiB() {} // Dummy constructor
				public lXvHoEyUvLMAAFqiBbrfAziZrSiB(Player player) {} // 0x0000000185BEF760-0x0000000185BEF800
	
				// Methods
				public void hGoGXvVewDdznIUDiLVJVGFrUsD(Joystick param_00008c28, CbjrqLOJCueoJWGbtJskOtJnHIE<JoystickMap> param_00008c29) {} // 0x0000000185BEF800-0x0000000185BEF9F0
				public void hGoGXvVewDdznIUDiLVJVGFrUsD(gvufEBygcUrXysEJzvawCPbsDrxh.dpfuhxZWxUFWcsMwcfGsBIKlIAP<Joystick, JoystickMap> param_00008c2a) {} // 0x0000000185BEF9F0-0x0000000185BEFA80
				public void pKEsuZWfZAjKixNVLfUzsvIMjPn() {} // 0x0000000185BEFB00-0x0000000185BEFC70
				public lPNGZhakaXfqCCtJBxZfQNjmlTSa OlRyGPawIBmfpGbjKDHJQXdzfaeG(int param_00008c2b) => default; // 0x0000000185BEF6C0-0x0000000185BEF760
				public int EAgOMouOjbslHCCsyBDLoGVrHcd(int param_00008c2c) => default; // 0x0000000185BEF5C0-0x0000000185BEF6C0
				public void nympziBLtYDUiPlWNRoEGqbSPfa() {} // 0x0000000185BEFA80-0x0000000185BEFB00
			}
	
			// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
			// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
			public sealed class MapHelper : CodeHelper // TypeDefIndex: 4212
			{
				// Fields
				private readonly LDQPFPXQyLIyqtAUvmVCEbFpcBq cJTNmPpeWvIJgiCSyEVEQjjwqNa; // 0x10
				private Player sKXWHubnVhxWhOxTHOuVspOItdX; // 0x18
				private ControllerHelper GXjksnimfWszjuquGUzFlFpJFosa; // 0x20
				private readonly ControllerMapEnabler ipSAoXCGDxhQUPqUAHJmTJboVIO; // 0x28
				private readonly ControllerMapLayoutManager YLROIErYwOPTkeRBTahBxTeCLrV; // 0x30
				private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x38
	
				// Properties
				public ControllerMapLayoutManager layoutManager { get => default; } // 0x0000000185BDB5D0-0x0000000185BDB630 
				public ControllerMapEnabler mapEnabler { get => default; } // 0x0000000185BDB630-0x0000000185BDB690 
				public IList<InputBehavior> InputBehaviors { get => default; } // 0x0000000185BDB4A0-0x0000000185BDB5D0 
	
				// Constructors
				public MapHelper() {} // Dummy constructor
				internal MapHelper(Player player, ControllerHelper parent, LDQPFPXQyLIyqtAUvmVCEbFpcBq startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.JUZYTaWfnqZOjNkWvtfvZbKqPkC controllerMapEnablerSettings) {} // 0x0000000185BDA580-0x0000000185BDA6C0
	
				// Methods
				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId, bool startEnabled) {} // 0x0000000185BD8E40-0x0000000185BD8F00
				private void pXYfnQEdokjJNRGUeYcypfzibHbd(ControllerType param_00008c3a, int param_00008c3b, int param_00008c3c, int param_00008c3d, BoolOption param_00008c3e) {} // 0x0000000185BDC2E0-0x0000000185BDC400
				public int GetAllMaps(List<ControllerMap> results) => default; // 0x0000000185BD7330-0x0000000185BD7600
				public int GetAllMaps(ControllerType controllerType, List<ControllerMap> results) => default; // 0x0000000185BD7600-0x0000000185BD7A00
				public IList<T> GetMaps<T>(int controllerId)
					where T : ControllerMap => default;
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int mapId) => default; // 0x0000000185BD8430-0x0000000185BD8530
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId) => default; // 0x0000000185BD8300-0x0000000185BD8430
				public ControllerMap GetMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName) => default; // 0x0000000185BD8640-0x0000000185BD8750
				public ControllerMap GetMap(Controller controller, int categoryId, int layoutId) => default; // 0x0000000185BD8750-0x0000000185BD8860
				public ControllerMap GetMap(Controller controller, string categoryName, string layoutName) => default; // 0x0000000185BD8530-0x0000000185BD8640
				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, int categoryId) => default; // 0x0000000185BD80F0-0x0000000185BD81F0
				public void AddMap(Controller controller, ControllerMap map) {} // 0x0000000185BD6360-0x0000000185BD6490
				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map) {} // 0x0000000185BD6230-0x0000000185BD6360
				public void RemoveMap(ControllerType controllerType, int controllerId, int mapId) {} // 0x0000000185BD9600-0x0000000185BD9720
				public void ClearMaps(ControllerType controllerType, bool userAssignableOnly) {} // 0x0000000185BD6680-0x0000000185BD6A10
				public void ClearAllMaps(bool userAssignableOnly) {} // 0x0000000185BD6490-0x0000000185BD6680
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) => default; // 0x0000000185BD7B10-0x0000000185BD7C10
				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) => default; // 0x0000000185BD7C10-0x0000000185BD7D50
				public ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) => default; // 0x0000000185BD7D50-0x0000000185BD7FB0
				public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps) => default; // 0x0000000185BD7FB0-0x0000000185BD80F0
				public int GetElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) => default; // 0x0000000185BD7A00-0x0000000185BD7B10
				public ControllerMapSaveData[] GetMapSaveData(ControllerType controllerType, int controllerId, bool userAssignableMapsOnly) => default; // 0x0000000185BD81F0-0x0000000185BD8300
				public T[] GetAllMapSaveData<T>(bool userAssignableMapsOnly)
					where T : ControllerMapSaveData => default;
				public int SetMapsEnabled(bool state, int categoryId) => default; // 0x0000000185BD9720-0x0000000185BD9BE0
				public int SetMapsEnabled(bool state, string categoryName) => default; // 0x0000000185BD9BE0-0x0000000185BD9D10
				public void LoadDefaultMaps(ControllerType controllerType) {} // 0x0000000185BD8C50-0x0000000185BD8E40
				public bool ContainsMapInCategory(ControllerType controllerType, int categoryId) => default; // 0x0000000185BD6A10-0x0000000185BD6D80
				internal void YJaAHaimrHWIfKrgfWxeihnqrcza() {} // 0x0000000185BD9E00-0x0000000185BD9EB0
				internal void fmzvPqfOMREthSNifiIVbfxidRf(bool param_00008c7b) {} // 0x0000000185BDAE90-0x0000000185BDB4A0
				internal void ZiOtfyiFJruheJOmPVfgJhkZapP(bool param_00008c7c) {} // 0x0000000185BD9EB0-0x0000000185BDA580
				internal void MqFYiibffvHsqbxSBlCwKKPzqQau(bool param_00008c7d) {} // 0x0000000185BD8F00-0x0000000185BD9600
				internal void vvDcRWDrcNcvvBlFkksmmDDXmLKX(bool param_00008c7e) {} // 0x0000000185BDCE30-0x0000000185BDD500
				private kHMsYjJiKwOpoEpeOCPidxMTpkK baXNIoPqUMOVyILBCtdaqqHvsad<T>()
					where T : ControllerMap => default;
				internal CbjrqLOJCueoJWGbtJskOtJnHIE<JoystickMap> IaJmPVPlciNYWLsbnVDNccmRkKG(Joystick param_00008c7f, bool param_00008c80) => default; // 0x0000000185BD8A60-0x0000000185BD8C50
				private void oDKOkmyvREkCyZNvqRZYwsxdcpn(Joystick param_00008c81, CbjrqLOJCueoJWGbtJskOtJnHIE<JoystickMap> param_00008c82, LbyXjOIzPbSKtwNeSiJafzWOdxVB param_00008c83, bool param_00008c84) {} // 0x0000000185BDC0C0-0x0000000185BDC2E0
				internal CbjrqLOJCueoJWGbtJskOtJnHIE<CustomControllerMap> HIKGTKtpjAXNbbNsRMMuZLsfsga(CustomController param_00008c85, bool param_00008c86) => default; // 0x0000000185BD8860-0x0000000185BD8A60
				private void eqjcLKFbzcIkrAfminxytJTIohN(CustomController param_00008c87, CbjrqLOJCueoJWGbtJskOtJnHIE<CustomControllerMap> param_00008c88, LbyXjOIzPbSKtwNeSiJafzWOdxVB param_00008c89, bool param_00008c8a) {} // 0x0000000185BDAC50-0x0000000185BDAE90
				internal void WCmGeLfhpkcBkcwgHknyvrnPkrF(Controller param_00008c8b, ControllerMap param_00008c8c) {} // 0x0000000185BD9D10-0x0000000185BD9E00
				private IList<T> kBQWveGCdcuyPPipoqIkEfKCDlAb<T>(int param_00008c8d)
					where T : ControllerMap => default;
				private void gwCJtGMqbottiKuqfKQXUctncAL(ControllerType param_00008c8e, int param_00008c8f, int param_00008c90, int param_00008c91, BoolOption param_00008c92) {} // 0x0000000185BDBA90-0x0000000185BDBDC0
				private void dZiQrxeifCVQdHjYoSKcRMmmKCr(Controller param_00008c93, ControllerMap param_00008c94, BoolOption param_00008c95) {} // 0x0000000185BDA8F0-0x0000000185BDAC50
				private void dZiQrxeifCVQdHjYoSKcRMmmKCr(ControllerType param_00008c96, int param_00008c97, ControllerMap param_00008c98, BoolOption param_00008c99) {} // 0x0000000185BDA800-0x0000000185BDA8F0
				private void mpWSAQjebfNJwvGcrIASDCLFPdlz(ControllerType param_00008c9a, int param_00008c9b, int param_00008c9c) {} // 0x0000000185BDBDC0-0x0000000185BDC0C0
				private ControllerMap rfHDwAKBKUdJogVbZXJjkzGIgtGg(ControllerType param_00008c9d, int param_00008c9e, int param_00008c9f) => default; // 0x0000000185BDC400-0x0000000185BDC540
				private ControllerMap rfHDwAKBKUdJogVbZXJjkzGIgtGg(ControllerType param_00008ca0, int param_00008ca1, int param_00008ca2, int param_00008ca3) => default; // 0x0000000185BDC540-0x0000000185BDC680
				private ControllerMap rfHDwAKBKUdJogVbZXJjkzGIgtGg(ControllerType param_00008ca4, int param_00008ca5, string param_00008ca6, string param_00008ca7) => default; // 0x0000000185BDC680-0x0000000185BDC810
				private ControllerMap cxgDabysBLdPkVerkIzFNsvLDoH(ControllerType param_00008ca8, int param_00008ca9, int param_00008caa) => default; // 0x0000000185BDA6C0-0x0000000185BDA800
				private ControllerMapSaveData[] CwmYlGrGmNPDExqZncBwWxCguLG(ControllerType param_00008cab, int param_00008cac, bool param_00008cad) => default; // 0x0000000185BD6D80-0x0000000185BD7330
				private T[] GPsBcMksSHZentZMXykpnWCIUhh<T>(bool param_00008cae)
					where T : ControllerMapSaveData => default;
				private ActionElementMap trJBpnEaVSqTkoHkwTOBoLcABlMR(ControllerType param_00008caf, int param_00008cb0, bool param_00008cb1) => default; // 0x0000000185BDC810-0x0000000185BDCE30
				private int giqxdzUIzWzftJmdfHYxipRwIjBB(ControllerType param_00008cb2, int param_00008cb3, bool param_00008cb4, List<ActionElementMap> param_00008cb5, bool param_00008cb6) => default; // 0x0000000185BDB690-0x0000000185BDBA90
			}
	
			// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
			// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
			public sealed class PollingHelper : CodeHelper // TypeDefIndex: 4213
			{
				// Fields
				private readonly Player sKXWHubnVhxWhOxTHOuVspOItdX; // 0x10
				private readonly ControllerHelper GXjksnimfWszjuquGUzFlFpJFosa; // 0x18
				private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x20
	
				// Constructors
				public PollingHelper() {} // Dummy constructor
				internal PollingHelper(Player player, ControllerHelper parent) {} // 0x0000000185BE7AC0-0x0000000185BE7B90
	
				// Methods
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId) => default; // 0x0000000185BE75C0-0x0000000185BE7750
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId) => default; // 0x0000000185BE7430-0x0000000185BE75C0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId) => default; // 0x0000000185BE7290-0x0000000185BE7430
				private IEnumerable<ControllerPollingInfo> LmaAZmigKSKzeRdhfpRcpQoLEam(int param_00008cbf) => default; // 0x0000000185BE71F0-0x0000000185BE7290
				private IEnumerable<ControllerPollingInfo> SYgSdpphkaZENwexNJvseczkiYQ(int param_00008cc0) => default; // 0x0000000185BE7800-0x0000000185BE78A0
				private IEnumerable<ControllerPollingInfo> WhpDbcKIUTTzCrpOKBZEvSYhKeHC(int param_00008cc1) => default; // 0x0000000185BE7960-0x0000000185BE7A00
				private IEnumerable<ControllerPollingInfo> QBcgdYdqwsLotCArKVfGzZsRCKD() => default; // 0x0000000185BE7750-0x0000000185BE7800
				private IEnumerable<ControllerPollingInfo> TUrfKiUifMozUtgDHYzvZgHvzIw() => default; // 0x0000000185BE78A0-0x0000000185BE7960
				private IEnumerable<ControllerPollingInfo> YxKFHoPCWDOhrAoZxeOqaaLGcrXM() => default; // 0x0000000185BE7A00-0x0000000185BE7AC0
				private IEnumerable<ControllerPollingInfo> IyFFzGFhfcLDjpFDRMcEectHWpgg() => default; // 0x0000000185BE7140-0x0000000185BE71F0
				private IEnumerable<ControllerPollingInfo> BKJAXvDbuTnvWelHGsnFSuKqpXEc(int param_00008cc2) => default; // 0x0000000185BE6FD0-0x0000000185BE70A0
				private IEnumerable<ControllerPollingInfo> AtqrGKflGhvGEBYGxAVIkJNoaPsK(int param_00008cc3) => default; // 0x0000000185BE6EF0-0x0000000185BE6FD0
				private IEnumerable<ControllerPollingInfo> DAFLFoRFTmdXiAbpHJuGOlBavlVu(int param_00008cc4) => default; // 0x0000000185BE70A0-0x0000000185BE7140
			}
	
			// Constructors
			public ControllerHelper() {} // Dummy constructor
			internal ControllerHelper(Player player, LDQPFPXQyLIyqtAUvmVCEbFpcBq startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.JUZYTaWfnqZOjNkWvtfvZbKqPkC controllerMapEnablerSettings) {} // 0x0000000185BD0C00-0x0000000185BD1070
	
			// Methods
			public Controller GetController(ControllerType controllerType, int controllerId) => default; // 0x0000000185BCD7A0-0x0000000185BCD8C0
			public T GetControllerWithTag<T>(string tag)
				where T : Controller => default;
			public Controller GetControllerWithTag(ControllerType controllerType, string tag) => default; // 0x0000000185BCD680-0x0000000185BCD7A0
			public void AddController(Controller controller, bool removeFromOtherPlayers) {} // 0x0000000185BCC620-0x0000000185BCC920
			public void AddController(ControllerType controllerType, int controllerId, bool removeFromOtherPlayers) {} // 0x0000000185BCC920-0x0000000185BCCC90
			public void RemoveController(ControllerType controllerType, int controllerId) {} // 0x0000000185BCF8F0-0x0000000185BCFAE0
			public void RemoveController(Controller controller) {} // 0x0000000185BCF6B0-0x0000000185BCF8F0
			public bool ContainsController(ControllerType controllerType, int controllerId) => default; // 0x0000000185BCD3B0-0x0000000185BCD590
			public bool ContainsController(Controller controller) => default; // 0x0000000185BCD590-0x0000000185BCD680
			public void ClearControllersOfType(ControllerType controllerType) {} // 0x0000000185BCD1B0-0x0000000185BCD3B0
			public Controller GetLastActiveController() => default; // 0x0000000185BCDB40-0x0000000185BCDCD0
			public Controller GetLastActiveController(ControllerType controllerType) => default; // 0x0000000185BCDCD0-0x0000000185BCDF00
			private void AhSsxJlgcgunjgMNdnhEOheEImi(ControllerType param_00008b95, ref Controller param_00008b96, ref float param_00008b97) {} // 0x0000000185BCCDC0-0x0000000185BCD1B0
			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback) {} // 0x0000000185BCCC90-0x0000000185BCCDC0
			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback) {} // 0x0000000185BCFAE0-0x0000000185BCFC40
			public Controller GetFirstControllerWithTemplate(System.Type templateType) => default; // 0x0000000185BCD8C0-0x0000000185BCDB40
			public Controller GetFirstControllerWithTemplate<T>()
				where T : class => default;
			private Controller lTxtAXlrAeJkXOOFybmpgdfnuYR<TDelegateParam>(ControllerType param_00008b9b, Func<Controller, TDelegateParam, bool> param_00008b9c, TDelegateParam param_00008b9d) => default;
			internal void YJaAHaimrHWIfKrgfWxeihnqrcza() {} // 0x0000000185BD0710-0x0000000185BD0C00
			internal float XXTbAdtxZQctMkRGrECRxopILGib(int param_00008b9e) => default; // 0x0000000185BD0670-0x0000000185BD0710
			internal void LQGxclUaisClvyzkifGfZFVUDUD(Joystick param_00008b9f, bool param_00008ba0) {} // 0x0000000185BCE870-0x0000000185BCECB0
			internal void zwbHitsqiXGFqJjlZgUaENxJxbF(int param_00008ba1) {} // 0x0000000185BD2E20-0x0000000185BD3130
			internal void zwbHitsqiXGFqJjlZgUaENxJxbF(Joystick param_00008ba2) {} // 0x0000000185BD3130-0x0000000185BD31D0
			internal void NnwArLllunfjfWxUXctYidAGzIA() {} // 0x0000000185BCECB0-0x0000000185BCEFE0
			internal void NsKfrPICAOsMNxuGJtMJgtOYkyHW(CustomController param_00008ba3, bool param_00008ba4) {} // 0x0000000185BCEFE0-0x0000000185BCF370
			internal void PDQUjpckXCQXzCfTVwQoaafKrYv(int param_00008ba5) {} // 0x0000000185BCF410-0x0000000185BCF6B0
			internal void PDQUjpckXCQXzCfTVwQoaafKrYv(CustomController param_00008ba6) {} // 0x0000000185BCF370-0x0000000185BCF410
			internal void wJeSQJwlUeCidHFkHLIviekeEVUH() {} // 0x0000000185BD2890-0x0000000185BD2E20
			internal void rbYFtbFaFEhrhgWrFWZWpRPDXwxr(Action<bool, int, int> param_00008ba7) {} // 0x0000000185BD1EA0-0x0000000185BD1F20
			internal void WslLBNcDnxzGOLiXkFkbccuqAkTE(Keyboard param_00008ba8, dAsBJCqlFUZsWwFTjrjITxqcqDX param_00008ba9, Action<bool, int, int> param_00008baa) {} // 0x0000000185BCFC40-0x0000000185BD0480
			private static void XGLGSKJyYgWKMdJGPyPZoqhuLWP(Keyboard param_00008bab, ControllerMap param_00008bac, ActionElementMap param_00008bad, YELADGAuWhMAnmQvkxgchkzhIWFg param_00008bae, ButtonStateFlags param_00008baf) {} // 0x0000000185BD0480-0x0000000185BD0670
			internal void HENpcWgIFRCGiusZHVwhlTSsldT(Mouse param_00008bb0, Action<bool, int, int> param_00008bb1) {} // 0x0000000185BCDF00-0x0000000185BCE870
			internal void hzXHiHclGzAMbdQKsGWYtSNRhgUN(Action<bool, int, int> param_00008bb2) {} // 0x0000000185BD1E20-0x0000000185BD1EA0
			private void kkciGPwoTKGQHUrFTDqzOIoNxQq<T, TMap>(ControllerType param_00008bb3, Action<bool, int, int> param_00008bb4)
				where T : ControllerWithAxes
				where TMap : ControllerMapWithAxes {}
			private bool LbeRrifrXiJHtAoAabFMopHsSHp<TMap>(ControllerWithAxes param_00008bb5, int param_00008bb6, int param_00008bb7, ActionElementMap param_00008bb8, CbjrqLOJCueoJWGbtJskOtJnHIE<TMap> param_00008bb9, int param_00008bba, ref float param_00008bbb)
				where TMap : ControllerMapWithAxes => default;
			private bool LvOxyHgBrWHMNuPWamqBqCDGHGr<TMap>(UnknownControllerHat.HatButtons param_00008bbc, int param_00008bbd, CbjrqLOJCueoJWGbtJskOtJnHIE<TMap> param_00008bbe)
				where TMap : ControllerMapWithAxes => default;
			private bool XjWStuLriBTiDocsYRiBDurCqXv<TMap>(UnknownControllerHat.HatButtons param_00008bbf, int param_00008bc0, CbjrqLOJCueoJWGbtJskOtJnHIE<TMap> param_00008bc1)
				where TMap : ControllerMapWithAxes => default;
		}
	
		// Constructors
		public Player() {} // Dummy constructor
		internal Player(bool isSystem, int playerId, string name, string descriptiveName, LDQPFPXQyLIyqtAUvmVCEbFpcBq startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.JUZYTaWfnqZOjNkWvtfvZbKqPkC controllerMapEnablerSettings) {} // 0x0000000185BE6950-0x0000000185BE6AD0
	
		// Methods
		public PlayerSaveData GetSaveData(bool userAssignableMapsOnly) => default; // 0x0000000185BE6620-0x0000000185BE68D0
		public bool GetButton(int actionId) => default; // 0x0000000185BE5C70-0x0000000185BE5DC0
		public bool GetButtonDown(string actionName) => default; // 0x0000000185BE5280-0x0000000185BE5390
		public bool GetButtonDown(int actionId) => default; // 0x0000000185BE5390-0x0000000185BE54A0
		public bool GetButtonUp(int actionId) => default; // 0x0000000185BE5B40-0x0000000185BE5C70
		public bool GetButtonDoublePressHold(int actionId, float speed) => default; // 0x0000000185BE5160-0x0000000185BE5280
		public bool GetButtonDoublePressHold(int actionId) => default; // 0x0000000185BE50E0-0x0000000185BE5160
		public bool GetButtonShortPress(int actionId) => default; // 0x0000000185BE5A30-0x0000000185BE5B40
		public bool GetButtonShortPressUp(int actionId) => default; // 0x0000000185BE5920-0x0000000185BE5A30
		public bool GetButtonLongPress(int actionId) => default; // 0x0000000185BE56E0-0x0000000185BE57F0
		public bool GetButtonLongPressDown(int actionId) => default; // 0x0000000185BE54A0-0x0000000185BE55D0
		public bool GetButtonLongPressUp(int actionId) => default; // 0x0000000185BE55D0-0x0000000185BE56E0
		public bool GetButtonRepeating(int actionId) => default; // 0x0000000185BE57F0-0x0000000185BE5920
		public bool GetNegativeButton(int actionId) => default; // 0x0000000185BE6500-0x0000000185BE6620
		public bool GetNegativeButtonDown(int actionId) => default; // 0x0000000185BE60A0-0x0000000185BE61B0
		public bool GetNegativeButtonDoublePressHold(int actionId, float speed) => default; // 0x0000000185BE5F00-0x0000000185BE6020
		public bool GetNegativeButtonDoublePressHold(int actionId) => default; // 0x0000000185BE6020-0x0000000185BE60A0
		public bool GetNegativeButtonShortPress(int actionId) => default; // 0x0000000185BE63F0-0x0000000185BE6500
		public bool GetNegativeButtonLongPress(int actionId) => default; // 0x0000000185BE61B0-0x0000000185BE62E0
		public bool GetNegativeButtonRepeating(int actionId) => default; // 0x0000000185BE62E0-0x0000000185BE63F0
		public float GetAxis(string actionName) => default; // 0x0000000185BE4FD0-0x0000000185BE50E0
		public float GetAxis(int actionId) => default; // 0x0000000185BE4EC0-0x0000000185BE4FD0
		public float GetAxisRaw(int actionId) => default; // 0x0000000185BE4C20-0x0000000185BE4D60
		public float GetAxisTimeActive(int actionId) => default; // 0x0000000185BE4D60-0x0000000185BE4EC0
		public AxisCoordinateMode GetAxisCoordinateMode(int actionId) => default; // 0x0000000185BE4B10-0x0000000185BE4C20
		public IList<InputActionSourceData> GetCurrentInputSources(int actionId) => default; // 0x0000000185BE5DC0-0x0000000185BE5F00
		private void YJaAHaimrHWIfKrgfWxeihnqrcza() {} // 0x0000000185BE68D0-0x0000000185BE6950
	}
}
