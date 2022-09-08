/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class InputMapper // TypeDefIndex: 4153
	{
		// Fields
		private static InputMapper LDwDTzcqSaJaAJzktFPjtpIxftC; // 0x00
		private static int yyRdqIEdvRRWoOnhAbeUyuGapvs; // 0x08
		private readonly int NSjeQKhFJTlDoDGngvEElQKKyTlz; // 0x10
		private readonly bool DKKsJhVovhSPQzaEeMupVTQYArh; // 0x14
		private readonly xlOJLpgJJfXVaPWsEGwGQOBixwQ VccATGwRZfmxpmjVYmFvhxHzNPx; // 0x18
		private Options MGWGRaaUsLnBlOlSCboSclEJLTF; // 0x20
		private readonly Dictionary<UXYouNakldlxUGpBJZwRfsHbFnY, SafeDelegate> dZGokImSjoemMGGmOJRNqoGONls; // 0x28
	
		// Properties
		public static InputMapper Default { get => default; } // 0x000000018583B6D0-0x000000018583B7A0 
		public Options options { get => default; } // 0x000000018583B7A0-0x000000018583B890 
		public Status status { get => default; } // 0x000000018583B890-0x000000018583B910 
		public float timeRemaining { get => default; } // 0x000000018583B910-0x000000018583B990 
	
		// Events
		public event Action<InputMappedEventData> InputMappedEvent;
		public event Action<StoppedEventData> StoppedEvent;
		public event Action<ConflictFoundEventData> ConflictFoundEvent;
	
		// Nested types
		public class Context // TypeDefIndex: 4154
		{
			// Fields
			private int mecAvOSCkKTUzDMSKLpGqHuOJBZ; // 0x10
			private ControllerMap JdetZGSYAxuUPraClBlCSLMWOmU; // 0x18
			private ActionElementMap ipcPpQHebCyxuIFYuOhfFscSDfr; // 0x20
			private AxisRange ORRYCyGQPzowEtoVbQfooaVIMXi; // 0x28
			private bool opqFCidZJywDAhKxeolcaVpqNEsC; // 0x2C
	
			// Properties
			public int actionId { get => default; set {} } // 0x00000001852F2270-0x00000001852F22D0 0x00000001852F2530-0x00000001852F25B0
			public ControllerMap controllerMap { get => default; set {} } // 0x00000001852F2330-0x00000001852F2390 0x00000001852F2630-0x00000001852F26B0
			public ActionElementMap actionElementMapToReplace { get => default; set {} } // 0x00000001852F2210-0x00000001852F2270 0x00000001852F24B0-0x00000001852F2530
			public AxisRange actionRange { get => default; set {} } // 0x00000001852F22D0-0x00000001852F2330 0x00000001852F25B0-0x00000001852F2630
	
			// Constructors
			public Context() {} // 0x00000001852F21A0-0x00000001852F2210
			private Context(Context source) {} // 0x00000001852F2070-0x00000001852F21A0
	
			// Methods
			public Context Clone() => default; // 0x00000001852F1E70-0x00000001852F1EF0
			internal void lVOUSoXYpQJOYtyyJniiNkDHvOt() {} // 0x00000001852F2390-0x00000001852F23F0
			private bool mOrcqprUQEbTcotWIYrfFcPKnbe() => default; // 0x00000001852F23F0-0x00000001852F24B0
			public static void Copy(Context source, Context destination) {} // 0x00000001852F1EF0-0x00000001852F2070
		}
	
		public enum ConflictResponse // TypeDefIndex: 4155
		{
			Cancel = 0,
			Replace = 1,
			Add = 2,
			Ignore = 3
		}
	
		public abstract class EventData // TypeDefIndex: 4156
		{
			// Fields
			public readonly InputMapper inputMapper; // 0x10
	
			// Constructors
			protected EventData() {} // Dummy constructor
			internal EventData(InputMapper inputMapper) {} // 0x00000001852F3B10-0x00000001852F3B80
		}
	
		public class InputMappedEventData : EventData // TypeDefIndex: 4157
		{
			// Fields
			public readonly ActionElementMap actionElementMap; // 0x18
	
			// Constructors
			public InputMappedEventData() {} // Dummy constructor
			internal InputMappedEventData(InputMapper mapper, ActionElementMap actionElementMap) {} // 0x00000001852F5B00-0x00000001852F5BB0
		}
	
		public class CanceledEventData : EventData // TypeDefIndex: 4158
		{
			// Fields
			public readonly string message; // 0x18
	
			// Constructors
			public CanceledEventData() {} // Dummy constructor
			internal CanceledEventData(InputMapper mapper, string message) {} // 0x00000001852F1CF0-0x00000001852F1DA0
		}
	
		public class ErrorEventData : EventData // TypeDefIndex: 4159
		{
			// Fields
			public readonly string message; // 0x18
	
			// Constructors
			public ErrorEventData() {} // Dummy constructor
			internal ErrorEventData(InputMapper mapper, string message) {} // 0x00000001852F3A20-0x00000001852F3B10
		}
	
		public class TimedOutEventData : EventData // TypeDefIndex: 4160
		{
			// Constructors
			public TimedOutEventData() {} // Dummy constructor
			internal TimedOutEventData(InputMapper mapper) {} // 0x000000018530E0E0-0x000000018530E190
		}
	
		public class StartedEventData : EventData // TypeDefIndex: 4161
		{
			// Constructors
			public StartedEventData() {} // Dummy constructor
			internal StartedEventData(InputMapper mapper) {} // 0x000000018530DF80-0x000000018530E030
		}
	
		public class StoppedEventData : EventData // TypeDefIndex: 4162
		{
			// Constructors
			public StoppedEventData() {} // Dummy constructor
			internal StoppedEventData(InputMapper mapper) {} // 0x000000018530E030-0x000000018530E0E0
		}
	
		public class ConflictFoundEventData : EventData // TypeDefIndex: 4163
		{
			// Fields
			public readonly Action<ConflictResponse> responseCallback; // 0x18
			public readonly ElementAssignmentInfo assignment; // 0x20
			public readonly IList<ElementAssignmentConflictInfo> conflicts; // 0x28
			public readonly bool isProtected; // 0x30
	
			// Constructors
			public ConflictFoundEventData() {} // Dummy constructor
			internal ConflictFoundEventData(InputMapper mapper, Action<ConflictResponse> responseCallback, ElementAssignmentInfo assignment, IList<ElementAssignmentConflictInfo> conflicts, bool isProtected) {} // 0x00000001852F1DA0-0x00000001852F1E70
		}
	
		private enum UXYouNakldlxUGpBJZwRfsHbFnY // TypeDefIndex: 4164
		{
			OmJJiAbuTlMOWIkAgcVQUFjQEAm = 0,
			VoYMRlwACsraKOTYBiskDczbVjo = 1,
			gzLqQnynNiJYtnZJePCSdCDkTrO = 2,
			VLEgdOXdNXEqLkwpfjLktnYglPD = 3,
			ECstDpRUIjTqYIfJBeeiBNYZPCXD = 4,
			OyxFxlwKPbfcFNqcNGJfFiIzZsh = 5,
			PNsOoVDscRjIIcOTxLbztPuczOy = 6
		}
	
		public enum Status // TypeDefIndex: 4165
		{
			Idle = 0,
			Listening = 1,
			AwaitingResponse = 2
		}
	
		private class xlOJLpgJJfXVaPWsEGwGQOBixwQ // TypeDefIndex: 4166
		{
			// Fields
			private readonly InputMapper HQqdfhbximGRqAmWjsGgpbsZYxai; // 0x10
			private readonly Options MGWGRaaUsLnBlOlSCboSclEJLTF; // 0x18
			private readonly NwTBVHLrJkTpiloHvLCuTsuTrZX gIZiNOqOAUJCvbMmHalEdlHWTGw; // 0x20
			private readonly Dictionary<UXYouNakldlxUGpBJZwRfsHbFnY, SafeDelegate> dZGokImSjoemMGGmOJRNqoGONls; // 0x28
			private readonly Dictionary<string, SafeDelegate> nRnbOfaWdIOaTEWGnsecocCmxTd; // 0x30
			private Status aVAzLFOVTwEIIeAagBoqWuSMwpm; // 0x38
			private RGjyCYPYxluyfyGrtLVAbXariyK HngDxilgQmbwjsagxMCXiPLELnh; // 0x3C
			private float pLGxTvJaeesjQEGSciDKsxLuPnH; // 0x40
			private bool VXFjOijMeJDEAHfZqvVYOvfuEjFk; // 0x44
			private List<Player> DqtoJzdwDWPOsAOrFfygWfukmws; // 0x48
			private readonly List<ControllerPollingInfo> oVuZsffNUnwzYUeuEMVsiCKzdgZi; // 0x50
			private ElementAssignment NIlKGCoBBfSEroMIDVVyMTvpbkT; // 0x58
	
			// Properties
			public Status TgMCCkEXzaOOyKFCEicPgvOxVpL { get => default; } // 0x0000000185316740-0x00000001853167A0 
			public float KTkEFLIrVpOyRIxlRXqQQTDFmdfe { get => default; } // 0x00000001853167A0-0x0000000185316900 
			private bool EgwQNgyXteflTDBKKcBKEyYpizoh { get => default; } // 0x0000000185316670-0x0000000185316740 
	
			// Nested types
			private enum ohUXXWfZssPClVYzQxQvgfSVcCm // TypeDefIndex: 4167
			{
				xbpoFKhAMiHPoxbuCFYiAMKDcbSD = 0,
				jESAGZsozYRyAOXvqeivTgkAVcR = 1
			}
	
			private enum RGjyCYPYxluyfyGrtLVAbXariyK // TypeDefIndex: 4168
			{
				TCGihQKDgeeGtvEXifcuojmabzj = 0,
				vgIbcuPrbvHqzdJhfvSSOCJLtfa = 1
			}
	
			private class NwTBVHLrJkTpiloHvLCuTsuTrZX // TypeDefIndex: 4169
			{
				// Fields
				private Player wVmxupsXoTmxeBeKFxYheQCHgkk; // 0x10
				private int mecAvOSCkKTUzDMSKLpGqHuOJBZ; // 0x18
				private Context xKtEDyBLZjygWwghTOQMNuqQPHDe; // 0x20
				private ControllerType xRMUSowrwSVmfxjnqwQXevUgxsr; // 0x28
				private int ruGCBfCWNtGZeTUKxKBCHIMxrSyL; // 0x2C
				private ControllerPollingInfo lDdCZddqmCfteXCQzyIOcdqLiDtb; // 0x30
				private ModifierKeyFlags EuXSHfxCxOKWtPSMReFOETpbVgh; // 0x68
	
				// Properties
				public Player sKXWHubnVhxWhOxTHOuVspOItdX { get => default; } // 0x0000000185301B00-0x0000000185301B60 
				public Context SIlkHjJCgFEwYDSCJbTUInhiAtD { get => default; } // 0x0000000185301AA0-0x0000000185301B00 
				public ControllerType SlhgqMdZzgOWWmMwSscraDibqHK { get => default; } // 0x0000000185301A40-0x0000000185301AA0 
				public int GhjqCtnpODoJyBkGbpQobNAcMtI { get => default; } // 0x00000001853019E0-0x0000000185301A40 
				public ControllerPollingInfo LjHvFPHgKiKMWevJjdozVRJDhWY { get => default; } // 0x0000000185301B60-0x0000000185301BE0 
				public AxisRange GsnVEUNrADoUdYdWxqJZnmbrmhn { get => default; } // 0x0000000185301730-0x00000001853019E0 
	
				// Constructors
				public NwTBVHLrJkTpiloHvLCuTsuTrZX() {} // 0x00000001853016D0-0x0000000185301730
	
				// Methods
				public void YJaAHaimrHWIfKrgfWxeihnqrcza(Player param_00008b3c, Context param_00008b3d) {} // 0x00000001853012E0-0x00000001853016D0
				public void nympziBLtYDUiPlWNRoEGqbSPfa() {} // 0x0000000185301BE0-0x0000000185301C70
				public ElementAssignment FhSaQydICWxGOvbPcwjexviqweu(ControllerPollingInfo param_00008b3e) => default; // 0x0000000185301220-0x00000001853012E0
				public ElementAssignment FhSaQydICWxGOvbPcwjexviqweu() => default; // 0x0000000185300F60-0x0000000185301220
			}
	
			// Constructors
			public xlOJLpgJJfXVaPWsEGwGQOBixwQ() {} // Dummy constructor
			public xlOJLpgJJfXVaPWsEGwGQOBixwQ(InputMapper parent, Dictionary<UXYouNakldlxUGpBJZwRfsHbFnY, SafeDelegate> events) {} // 0x0000000185315B50-0x0000000185315D00
	
			// Methods
			~xlOJLpgJJfXVaPWsEGwGQOBixwQ() {} // 0x0000000185313BE0-0x0000000185313C90
			public void HTeWiJSswgFIFVAtPBCSclhPFDl(Context param_00008b05, Options param_00008b06) {} // 0x0000000185313D30-0x0000000185314240
			public void XTKZapaesauuSnehMdoOWqLizpV(string param_00008b07) {} // 0x0000000185315450-0x0000000185315530
			private void UZSQFwoMfSAzsmmSKmseCCiJWWD(UpdateLoopType param_00008b08) {} // 0x0000000185314DB0-0x0000000185315190
			private void GUDzwCHJALfoEQNzBBdJDJLeotpg() {} // 0x0000000185313C90-0x0000000185313D30
			private void CbNIcrvnFQKuUFKiCEsYAUrFeFbZ() {} // 0x0000000185312D30-0x0000000185312E00
			private ohUXXWfZssPClVYzQxQvgfSVcCm tRpcfNzBijCFTIemMnhwmxtUXBvI(out ElementAssignment param_00008b09) {
				param_00008b09 = default;
				return default;
			} // 0x0000000185317470-0x0000000185317B00
			private bool dCtmIEdnvalHKWvnfEOtWOlGmvS(out IEnumerable<ControllerPollingInfo> param_00008b0a, out ModifierKeyFlags param_00008b0b) {
				param_00008b0a = default;
				param_00008b0b = default;
				return default;
			} // 0x0000000185315EC0-0x0000000185316600
			private IEnumerable<ControllerPollingInfo> sUUxoCSLCTyEqzZfObccHPWlNcI(out ModifierKeyFlags param_00008b0c) {
				param_00008b0c = default;
				return default;
			} // 0x0000000185317300-0x0000000185317470
			private ControllerPollingInfo EHkOyqEHrMkyTfFQOGkKcviefxo(Options param_00008b0d, out ModifierKeyFlags param_00008b0e) {
				param_00008b0e = default;
				return default;
			} // 0x0000000185312FC0-0x00000001853131A0
			private static ControllerPollingInfo EHkOyqEHrMkyTfFQOGkKcviefxo(Options param_00008b0f, out bool param_00008b10, out ModifierKeyFlags param_00008b11, out string param_00008b12) {
				param_00008b10 = default;
				param_00008b11 = default;
				param_00008b12 = default;
				return default;
			} // 0x00000001853131A0-0x0000000185313B30
			private static bool NGhrZIkXPYMyeTRufBeEXVNcNdi(ControllerPollingInfo param_00008b13, Options param_00008b14) => default; // 0x0000000185314800-0x0000000185314A10
			private static bool EZsGcMDzqcvzbUSAJIrMbtqIvITZ(NwTBVHLrJkTpiloHvLCuTsuTrZX param_00008b15, ControllerPollingInfo param_00008b16, Options param_00008b17) => default; // 0x0000000185313B30-0x0000000185313BE0
			private void uUJhRbpAahxvBvZWqGvIJGEJIAN() {} // 0x0000000185317B00-0x0000000185318280
			private ohUXXWfZssPClVYzQxQvgfSVcCm cKLdHGmmOuLFbcZHhEyggmknJbG(ElementAssignment param_00008b18) => default; // 0x0000000185315D00-0x0000000185315EC0
			private static bool CZRQexcLCIhvpFDpakrGfGofAokL(NwTBVHLrJkTpiloHvLCuTsuTrZX param_00008b19, ElementAssignment param_00008b1a, List<Player> param_00008b1b) => default; // 0x0000000185312A90-0x0000000185312D30
			private static bool mEHzMHSijhuCUTDINZwzuAHaIhAH(NwTBVHLrJkTpiloHvLCuTsuTrZX param_00008b1c, ElementAssignment param_00008b1d, List<Player> param_00008b1e) => default; // 0x0000000185316A80-0x0000000185317050
			private static IList<ElementAssignmentConflictInfo> ZoRSMwoPAEurdYgKOCSPDEGOtUa(NwTBVHLrJkTpiloHvLCuTsuTrZX param_00008b1f, ElementAssignment param_00008b20, List<Player> param_00008b21) => default; // 0x0000000185315530-0x0000000185315B50
			private static bool ulWqcbtRrVDfXhaimKgCPigUNPRU(NwTBVHLrJkTpiloHvLCuTsuTrZX param_00008b22, ElementAssignment param_00008b23, out ElementAssignmentConflictCheck param_00008b24) {
				param_00008b24 = default;
				return default;
			} // 0x0000000185318280-0x0000000185318770
			private static void MjFvPEZFPxxVhhWkhAaMlHfemxf(NwTBVHLrJkTpiloHvLCuTsuTrZX param_00008b25, ElementAssignment param_00008b26, List<Player> param_00008b27) {} // 0x0000000185314560-0x0000000185314800
			private void IpBMZCiRRpTeWUBEiCBfTyHblcV() {} // 0x0000000185314310-0x0000000185314410
			private void kzXBhGyWjBTlrtFPYjrYpJaqJnh() {} // 0x0000000185316900-0x00000001853169C0
			private bool JCVdrTvvkLIOjcSFfKtPoFETbzo(UXYouNakldlxUGpBJZwRfsHbFnY param_00008b28) => default; // 0x0000000185314410-0x00000001853144C0
			private void qaRmscmPBZVJYfZftZFplyrZnud<T>(UXYouNakldlxUGpBJZwRfsHbFnY param_00008b29, T param_00008b2a) {}
			private void LDnfGqAcIbYDmoxjrPhlvzERejy() {} // 0x00000001853144C0-0x0000000185314560
			private void VqsidoSoZGnlegwjTPBrunuJAOHG() {} // 0x00000001853153F0-0x0000000185315450
			private void UqFTZQqAyLuCXwkuvreLBEIFBcW(ActionElementMap param_00008b2b) {} // 0x0000000185315190-0x00000001853152D0
			private void DkZlmFflkYehgwevpfIMaArUCcI(string param_00008b2c) {} // 0x0000000185312F40-0x0000000185312FC0
			private ohUXXWfZssPClVYzQxQvgfSVcCm unVPnIkOCahXlHkbnxXkaUJXBto(ElementAssignment param_00008b2d) => default; // 0x0000000185318770-0x0000000185318A10
			private ohUXXWfZssPClVYzQxQvgfSVcCm SoZrLwjiJqHQgKBANWIiSyFVJsTq(ConflictResponse param_00008b2e, ElementAssignment param_00008b2f) => default; // 0x0000000185314CB0-0x0000000185314DB0
			private ohUXXWfZssPClVYzQxQvgfSVcCm SoZrLwjiJqHQgKBANWIiSyFVJsTq(ConflictResponse param_00008b30, ElementAssignment param_00008b31, bool param_00008b32) => default; // 0x0000000185314AD0-0x0000000185314CB0
			private void gUlQHbocwIkoqUNlFzMISNvIsuC() {} // 0x0000000185316600-0x0000000185316670
			private void DNdKpXPlwkBxjLiJVdllDGsZRdkV(string param_00008b33) {} // 0x0000000185312E00-0x0000000185312F40
			private void IPgLPvBhlHdWOeGkkjpRBoqjhiok() {} // 0x0000000185314240-0x0000000185314310
			private void VfYAtzbQvTdoWVaEgMfzYHEQMcsA() {} // 0x00000001853152D0-0x00000001853153F0
			private void BCEDcumkTDGFyXaljbtsIZrKCbg(ElementAssignment param_00008b34) {} // 0x0000000185312780-0x0000000185312900
			private void mBjiBErFHYBjWMkNxDiTAVvsLwz(ActionElementMap param_00008b35) {} // 0x00000001853169C0-0x0000000185316A80
			private void ocYrWbPNQlIQtBhLaBnPDBHtgQgr() {} // 0x0000000185317240-0x0000000185317300
			private void BYAwobnkzzBDKdhQjKwJLpCipCQt(string param_00008b36) {} // 0x0000000185312900-0x00000001853129D0
			private void nCyvIyCiYXbQKpQXorMHzNmuftAi(string param_00008b37) {} // 0x0000000185317050-0x0000000185317120
			private void ngnlUObIAicrGgdihUxdAbVvvTVN(ElementAssignmentInfo param_00008b38, IList<ElementAssignmentConflictInfo> param_00008b39, bool param_00008b3a) {} // 0x0000000185317120-0x0000000185317240
			private void RbUvVsAKdFieYTFMpRjguLEDMgC() {} // 0x0000000185314A10-0x0000000185314AD0
			private void CZCgztxDuzvWQfZETTBvRcpfINTb() {} // 0x00000001853129D0-0x0000000185312A90
			public void zKcwRdtVCiVejUgkovCTEizmsoA(ConflictResponse param_00008b3b) {} // 0x0000000185318A10-0x0000000185318BA0
		}
	
		public class Options // TypeDefIndex: 4170
		{
			// Fields
			internal const string KMuFpSYtLXgEvcaeMRQEIpVwhAV = "isElementAllowed"; // Metadata: 0x00AC4991
			private bool vRtHFcZElDYoHvxzJReNkEiatUd; // 0x10
			private bool niaxElEkPPyCWQpSdfBWKLNqrES; // 0x11
			private bool lvdXQAVuGOKCqiqXgkkhKTRtHsd; // 0x12
			private float IgbiKRnnKathmzTrgmoOckoKjWk; // 0x14
			private bool rbKOqysLAwCpqMMHmaZzfiQOebla; // 0x18
			private bool BoeaJreUnvzkMNHfFbmUtNOwoJAR; // 0x19
			private bool VguVAAGgAyhZAySqZAHaYueoQaJ; // 0x1A
			private bool NBwMjcSIwGVAgwbWYcSzHaoMqTgf; // 0x1B
			private int[] JBivnsZHgajLBmLKbyaXoojNBIq; // 0x20
			private ConflictResponse dOcCUeSDnApKvtHHKCszLcRQaFc; // 0x28
			private bool mSMFdpjtegqgJJumWWGruJuhEBkO; // 0x2C
			private bool GRSDNJGqNhYsKzVeUURdLrEAFuT; // 0x2D
			private bool OyyTJidQqHdTSiCiGbHAmtdnJAw; // 0x2E
			private bool PaMqgjMtbpawJFvAzBdtfjZmRLM; // 0x2F
			private float olrcBUbxXEwXVNAgIPPyvjWtwvci; // 0x30
			private readonly Dictionary<string, SafeDelegate> nRnbOfaWdIOaTEWGnsecocCmxTd; // 0x38
	
			// Properties
			public bool allowAxes { get => default; } // 0x0000000185302B00-0x0000000185302B60 
			public bool allowButtons { get => default; } // 0x0000000185302BC0-0x0000000185302C20 
			public bool allowButtonsOnFullAxisAssignment { get => default; set {} } // 0x0000000185302B60-0x0000000185302BC0 0x00000001853032F0-0x0000000185303350
			public float timeout { get => default; set {} } // 0x0000000185303050-0x00000001853030C0 0x0000000185303410-0x0000000185303490
			public bool checkForConflicts { get => default; } // 0x0000000185302E60-0x0000000185302EC0 
			public bool checkForConflictsWithAllPlayers { get => default; } // 0x0000000185302CE0-0x0000000185302D40 
			public bool checkForConflictsWithSelf { get => default; } // 0x0000000185302DA0-0x0000000185302E00 
			public bool checkForConflictsWithSystemPlayer { get => default; } // 0x0000000185302E00-0x0000000185302E60 
			public int[] checkForConflictsWithPlayerIds { get => default; } // 0x0000000185302D40-0x0000000185302DA0 
			public ConflictResponse defaultActionWhenConflictFound { get => default; } // 0x0000000185302EC0-0x0000000185302F20 
			public bool ignoreMouseXAxis { get => default; set {} } // 0x0000000185302F90-0x0000000185302FF0 0x0000000185303350-0x00000001853033B0
			public bool ignoreMouseYAxis { get => default; set {} } // 0x0000000185302FF0-0x0000000185303050 0x00000001853033B0-0x0000000185303410
			public bool allowKeyboardKeysWithModifiers { get => default; } // 0x0000000185302C20-0x0000000185302C80 
			public bool allowKeyboardModifierKeyAsPrimary { get => default; } // 0x0000000185302C80-0x0000000185302CE0 
			public float holdDurationToMapKeyboardModifierKeyAsPrimary { get => default; } // 0x0000000185302F20-0x0000000185302F90 
	
			// Constructors
			public Options() {} // 0x0000000185302A10-0x0000000185302B00
			private Options(Options source) {} // 0x00000001853028E0-0x0000000185302A10
	
			// Methods
			internal T pxbBXUyIaiMgcCSlqyLnQFalqSY<T>(string param_00008b43)
				where T : SafeDelegate => default;
			public Options Clone() => default; // 0x0000000185301DF0-0x0000000185301E70
			public override string ToString() => default; // 0x0000000185302240-0x00000001853028E0
			internal void nympziBLtYDUiPlWNRoEGqbSPfa() {} // 0x00000001853030C0-0x00000001853032F0
			public static void Copy(Options source, Options destination) {} // 0x0000000185301E70-0x0000000185302240
		}
	
		// Constructors
		public InputMapper() {} // 0x000000018583B360-0x000000018583B3F0
		private InputMapper(bool isDefault) {} // 0x000000018583AC10-0x000000018583B360
		static InputMapper() {} // 0x000000018583ABB0-0x000000018583AC10
	
		// Methods
		private static int oSterGHJiHAfEQCDtGKaynxpmaXj() => default; // 0x000000018583BA20-0x000000018583BB30
		public void RemoveAllEventListeners() {} // 0x000000018583A8C0-0x000000018583AA70
		public bool Start(Context mappingContext) => default; // 0x000000018583AA70-0x000000018583AB30
		public void Stop() {} // 0x000000018583AB30-0x000000018583ABB0
		private bool HTeWiJSswgFIFVAtPBCSclhPFDl(Context param_00008ae4, Options param_00008ae5) => default; // 0x000000018583A630-0x000000018583A830
	}
}
