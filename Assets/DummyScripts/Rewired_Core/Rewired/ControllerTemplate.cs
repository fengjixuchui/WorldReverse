/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public abstract class ControllerTemplate : IControllerTemplate // TypeDefIndex: 3656
	{
		// Fields
		private readonly string EqppaAHmTQvmVSSZadzlNpPBbHM; // 0x10
		private readonly Guid dZusnCybpGCwscophhHvAlacNbmR; // 0x18
		private readonly Controller HUdfNKdOgxfoxjMZAKUlkQYPszXh; // 0x28
		private readonly ADictionary<int, IControllerTemplateElement> edJpBRWMzLDFWGAvaqubNiceOqj; // 0x30
		private readonly ADictionary<string, IControllerTemplateElement> IfQIywqEvYkHjQlgQMdsAQrbUPJ; // 0x38
		private IControllerTemplateElement[] SERTGFptqMjtvIPNWFYznVbzAwf; // 0x40
		private ReadOnlyCollection<IControllerTemplateElement> uYCZQbMkrLLRfaHNIaSBlhhdXMi; // 0x48
		private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x50
	
		// Properties
		string IControllerTemplate.name { get; } // 0x0000000185D617D0-0x0000000185D618A0 
		Guid IControllerTemplate.typeGuid { get; } // 0x0000000185D618A0-0x0000000185D619C0 
		IList<IControllerTemplateElement> IControllerTemplate.elements { get; } // 0x0000000185D61700-0x0000000185D617D0 
		int IControllerTemplate.elementCount { get; } // 0x0000000185D61620-0x0000000185D61700 
	
		// Nested types
		internal abstract class QgSdyGzqsrxSGVEZPuwJASSKdjd : IControllerTemplateElement, IControllerTemplateElement_Internal // TypeDefIndex: 3657
		{
			// Fields
			private readonly IControllerTemplate HQqdfhbximGRqAmWjsGgpbsZYxai; // 0x10
			private readonly int rOuBUzbbciWwktcpmiPWpQIKoaAa; // 0x18
			private readonly string EqppaAHmTQvmVSSZadzlNpPBbHM; // 0x20
			private readonly ControllerTemplateElementType iaFziOmGetWMviBsUmpNhLnTJKt; // 0x28
			protected readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x2C
	
			// Properties
			public int fKtuodNzZLrsthNmhfemlCLUaYzG { get; } // 0x0000000185D6B850-0x0000000185D6B920 
			public string aDlMgGjNZuWBcXhALqKrSGlenWb { get; } // 0x0000000185D6B780-0x0000000185D6B850 
			public ControllerTemplateElementType HdaJmHCefHXcxpAZsILnwqxwADsE { get; } // 0x0000000185D6B920-0x0000000185D6B9F0 
			public abstract IControllerTemplateElementSource WVeuvvGVKxuwIVofyhIJOpLcDjb { get; }
			public abstract bool yZcCQGoBZVevzBXoFXZfemJfnrc { get; }
	
			// Constructors
			protected QgSdyGzqsrxSGVEZPuwJASSKdjd() {} // Dummy constructor
			protected QgSdyGzqsrxSGVEZPuwJASSKdjd(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType) {} // 0x0000000185D6B660-0x0000000185D6B780
	
			// Methods
			public abstract int GetElementTargets(ControllerElementTarget param_000080da, ref IList<ControllerTemplateElementTarget> param_000080db);
		}
	
		internal abstract class AOVYUFveXQbJGstCEjSTqLbprJy : QgSdyGzqsrxSGVEZPuwJASSKdjd // TypeDefIndex: 3658
		{
			// Fields
			protected readonly int RpNzlxacPwyuwFdbrmvHEuEJzjc; // 0x30
			protected readonly rlMFrkSNhflWEbbAbNShgGYIzlu[] HaUgwqZzDUwnOiQgtoLBdIMZTav; // 0x38
	
			// Properties
			public override bool yZcCQGoBZVevzBXoFXZfemJfnrc { get; } // 0x0000000185D54130-0x0000000185D54290 
	
			// Constructors
			protected AOVYUFveXQbJGstCEjSTqLbprJy() {} // Dummy constructor
			protected AOVYUFveXQbJGstCEjSTqLbprJy(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, IList<rlMFrkSNhflWEbbAbNShgGYIzlu> sourceElements) {} // 0x0000000185D54030-0x0000000185D54130
		}
	
		internal abstract class UDauPmAdOcMEjsLbmuQqmkmgNY : AOVYUFveXQbJGstCEjSTqLbprJy, IControllerTemplateAxis, IControllerTemplateButton // TypeDefIndex: 3659
		{
			// Fields
			private qFwngCMEUbVOUWUBpxMUVdPUzPt pjZjqriAjRgtRcmANkmfeRSKwaR; // 0x40
			private string XPnTvrAUYAzGhdGqNPKjneQiACY; // 0x48
			private string LrlbwFdVqTXHiNJRCEeCaoHmpfT; // 0x50
	
			// Properties
			public float CZnVxHmgUjKMWBbQBIDPHMRbcIP { get; } // 0x0000000185D70870-0x0000000185D70A40 
			public float YVPjZamcZgjuSruKLDKojliZWaR { get; } // 0x0000000185D70650-0x0000000185D70870 
			public bool EMZbXVXPLuILqYgGuvFKlphsdbl { get; } // 0x0000000185D70490-0x0000000185D70650 
			public bool WutNNBIWjxFJvQhrLiSPYtWXmXn { get; } // 0x0000000185D702F0-0x0000000185D70490 
			float tytgRxEHXameTppWyeTAfrewdMr { get; } // 0x0000000185D6F7F0-0x0000000185D6F8D0 
			float vVdSmujmlfnrNecIylJolUBgBYy { get; } // 0x0000000185D6F710-0x0000000185D6F7F0 
			IControllerTemplateAxisSource AfYrLolTOqeXIuEVQDyfzeeKTXV { get; } // 0x0000000185D6F640-0x0000000185D6F710 
			bool ggTwgmMaGydwmkLdNatVGafNaIz { get; } // 0x0000000185D700C0-0x0000000185D70190 
			bool oiYzsaJVHxdjfgwSYdECMqUDSTy { get; } // 0x0000000185D6FFF0-0x0000000185D700C0 
			bool rVZsmHkTvwSJWXGgnvpusbCEYIV { get; } // 0x0000000185D6F8D0-0x0000000185D6FB10 
			bool XTvsHYWYSFiypnRArUOsIYTrQWK { get; } // 0x0000000185D6FB10-0x0000000185D6FD60 
			float VCLDLNHljgGEQiFfzpaDtoPwKPb { get; } // 0x0000000185D6FE40-0x0000000185D6FF20 
			float ZPaBFkxsNAAAdJliidIFdnbnYOvG { get; } // 0x0000000185D6FD60-0x0000000185D6FE40 
			IControllerTemplateButtonSource NGApdjnJhNhgSdoziRgZKSkEnKmM { get; } // 0x0000000185D6FF20-0x0000000185D6FFF0 
			public override IControllerTemplateElementSource WVeuvvGVKxuwIVofyhIJOpLcDjb { get; } // 0x0000000185D70A40-0x0000000185D70B10 
	
			// Constructors
			protected UDauPmAdOcMEjsLbmuQqmkmgNY() {} // Dummy constructor
			protected UDauPmAdOcMEjsLbmuQqmkmgNY(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, qFwngCMEUbVOUWUBpxMUVdPUzPt target, IList<rlMFrkSNhflWEbbAbNShgGYIzlu> sourceElements) {} // 0x0000000185D70190-0x0000000185D702F0
	
			// Methods
			public override int GetElementTargets(ControllerElementTarget param_000080e9, ref IList<ControllerTemplateElementTarget> param_000080ea) => default; // 0x0000000185D6EEB0-0x0000000185D6F640
			private static bool sssIkmTnNOPAqsKgMlEiVVTuBVR(ControllerElementTarget param_000080eb, IControllerElementTarget param_000080ec) => default; // 0x0000000185D70B10-0x0000000185D70D10
		}
	
		internal sealed class tBNLiiJgIcMsUBoZQvzFXzKvOxV : UDauPmAdOcMEjsLbmuQqmkmgNY // TypeDefIndex: 3660
		{
			// Constructors
			public tBNLiiJgIcMsUBoZQvzFXzKvOxV() {} // Dummy constructor
			public tBNLiiJgIcMsUBoZQvzFXzKvOxV(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, qFwngCMEUbVOUWUBpxMUVdPUzPt target, IList<rlMFrkSNhflWEbbAbNShgGYIzlu> sourceElements) {} // 0x0000000185D776D0-0x0000000185D777F0
	
			// Methods
			internal static tBNLiiJgIcMsUBoZQvzFXzKvOxV EacwNkMfYaHjbQRdeDfnuPOoebXI(IControllerTemplate param_000080f4) => default; // 0x0000000185D77590-0x0000000185D776D0
		}
	
		internal sealed class WpdFlzbEtczXLQnJHCtnHeOuktW : UDauPmAdOcMEjsLbmuQqmkmgNY // TypeDefIndex: 3661
		{
			// Constructors
			public WpdFlzbEtczXLQnJHCtnHeOuktW() {} // Dummy constructor
			public WpdFlzbEtczXLQnJHCtnHeOuktW(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, qFwngCMEUbVOUWUBpxMUVdPUzPt target, IList<rlMFrkSNhflWEbbAbNShgGYIzlu> sourceElements) {} // 0x0000000185D72A50-0x0000000185D72B80
	
			// Methods
			internal static WpdFlzbEtczXLQnJHCtnHeOuktW EacwNkMfYaHjbQRdeDfnuPOoebXI(IControllerTemplate param_000080fc) => default; // 0x0000000185D72900-0x0000000185D72A50
		}
	
		internal abstract class yPzRqVcgcVcOvOJlFWoFIMAynfK : QgSdyGzqsrxSGVEZPuwJASSKdjd // TypeDefIndex: 3662
		{
			// Fields
			protected readonly int MyNJRXLJmKCNcpkEAMoRJKKLEAYf; // 0x30
			protected readonly QgSdyGzqsrxSGVEZPuwJASSKdjd[] SERTGFptqMjtvIPNWFYznVbzAwf; // 0x38
	
			// Properties
			public override bool yZcCQGoBZVevzBXoFXZfemJfnrc { get; } // 0x0000000185D791A0-0x0000000185D792F0 
			public override IControllerTemplateElementSource WVeuvvGVKxuwIVofyhIJOpLcDjb { get; } // 0x0000000185D792F0-0x0000000185D793B0 
	
			// Constructors
			protected yPzRqVcgcVcOvOJlFWoFIMAynfK() {} // Dummy constructor
			protected yPzRqVcgcVcOvOJlFWoFIMAynfK(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D79020-0x0000000185D791A0
	
			// Methods
			public override int GetElementTargets(ControllerElementTarget param_00008102, ref IList<ControllerTemplateElementTarget> param_00008103) => default; // 0x0000000185D78EF0-0x0000000185D79020
		}
	
		internal abstract class YGKhMizCnedpqehdtMmiwEvLoat : yPzRqVcgcVcOvOJlFWoFIMAynfK, IControllerTemplateAxis2D // TypeDefIndex: 3663
		{
			// Properties
			public Vector2 JHgsNLxiAQVnmyfVeWejfTJocIu { get; } // 0x0000000185D73DE0-0x0000000185D73FE0 
			public Vector2 NckTuqeNamazETPgRISbxBNlOkT { get; } // 0x0000000185D73BB0-0x0000000185D73DE0 
			public IControllerTemplateAxis raICbqlvpeOcxYeoWcHaCbkENNkG { get; } // 0x0000000185D73A90-0x0000000185D73BB0 
			public IControllerTemplateAxis IYPQsTiQVVsNElZmfRAxcKydzeL { get; } // 0x0000000185D73FE0-0x0000000185D74100 
	
			// Constructors
			protected YGKhMizCnedpqehdtMmiwEvLoat() {} // Dummy constructor
			protected YGKhMizCnedpqehdtMmiwEvLoat(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D739E0-0x0000000185D73A90
		}
	
		internal abstract class UpUEwdTTvOFgATFshDBLeowIyVJc : yPzRqVcgcVcOvOJlFWoFIMAynfK, IControllerTemplateAxis3D // TypeDefIndex: 3664
		{
			// Properties
			public Vector3 JHgsNLxiAQVnmyfVeWejfTJocIu { get; } // 0x0000000185D712A0-0x0000000185D71670 
			public Vector3 NckTuqeNamazETPgRISbxBNlOkT { get; } // 0x0000000185D70EE0-0x0000000185D712A0 
			public IControllerTemplateAxis raICbqlvpeOcxYeoWcHaCbkENNkG { get; } // 0x0000000185D70DC0-0x0000000185D70EE0 
			public IControllerTemplateAxis IYPQsTiQVVsNElZmfRAxcKydzeL { get; } // 0x0000000185D71670-0x0000000185D71790 
	
			// Constructors
			protected UpUEwdTTvOFgATFshDBLeowIyVJc() {} // Dummy constructor
			protected UpUEwdTTvOFgATFshDBLeowIyVJc(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D70D10-0x0000000185D70DC0
		}
	
		internal abstract class uxydodeweaeHWCGgEcCcmnfgWvV : yPzRqVcgcVcOvOJlFWoFIMAynfK, IControllerTemplateAxis6D // TypeDefIndex: 3665
		{
			// Properties
			public Vector3 tEMYkiFQKienxyrFYWbTzqLRlyG { get; } // 0x0000000185D77EB0-0x0000000185D78160 
			public Vector3 mSyJOBAWyVtxqOXfVCovcOZQOxq { get; } // 0x0000000185D778A0-0x0000000185D77B50 
			public Vector3 XBWDUzcsRJpKCaZAYZelsKQOcCsF { get; } // 0x0000000185D78880-0x0000000185D78B30 
			public Vector3 dyAhyjgtpbTOVwyOIIGwVLCYOWZZ { get; } // 0x0000000185D78160-0x0000000185D78520 
			public IControllerTemplateAxis NvdGgfgjxuUyQbnuNcICsiYDVrT { get; } // 0x0000000185D77B50-0x0000000185D77C70 
			public IControllerTemplateAxis VnalATHVcOsuGRoulkLmiKuCsWh { get; } // 0x0000000185D77C70-0x0000000185D77D90 
			public IControllerTemplateAxis bSDfzbzrPvthdrPeZPWPLgkMvJz { get; } // 0x0000000185D77D90-0x0000000185D77EB0 
			public IControllerTemplateAxis uIxiQyeNxzRCvbpoShCRimMvewdM { get; } // 0x0000000185D78520-0x0000000185D78640 
			public IControllerTemplateAxis YwycqgvyiMJoMqeOJdwtCDZpbqM { get; } // 0x0000000185D78640-0x0000000185D78760 
			public IControllerTemplateAxis HTTmZyzNWwVeveGMAxtqzmNoaHS { get; } // 0x0000000185D78760-0x0000000185D78880 
	
			// Constructors
			protected uxydodeweaeHWCGgEcCcmnfgWvV() {} // Dummy constructor
			protected uxydodeweaeHWCGgEcCcmnfgWvV(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D777F0-0x0000000185D778A0
		}
	
		internal sealed class mKyQUnsGROodYjDTwMLuDBCbgnEk : UpUEwdTTvOFgATFshDBLeowIyVJc, IControllerTemplateStick // TypeDefIndex: 3666
		{
			// Properties
			public IControllerTemplateAxis XBWDUzcsRJpKCaZAYZelsKQOcCsF { get => default; } // 0x0000000185D768C0-0x0000000185D769E0 
	
			// Constructors
			public mKyQUnsGROodYjDTwMLuDBCbgnEk() {} // Dummy constructor
			private mKyQUnsGROodYjDTwMLuDBCbgnEk(IControllerTemplate parent, int id, string name, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D76780-0x0000000185D768C0
			public mKyQUnsGROodYjDTwMLuDBCbgnEk(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY xAxis, UDauPmAdOcMEjsLbmuQqmkmgNY yAxis, UDauPmAdOcMEjsLbmuQqmkmgNY zAxis) {} // 0x0000000185D765D0-0x0000000185D76780
		}
	
		internal sealed class ftDvKTWdafBuuKtkJoadQljsejz : YGKhMizCnedpqehdtMmiwEvLoat, IControllerTemplateThumbStick // TypeDefIndex: 3667
		{
			// Properties
			public IControllerTemplateButton GydEvvfwUcSxnNcFUuZhNHHFCOw { get => default; } // 0x0000000185D743F0-0x0000000185D74510 
	
			// Constructors
			public ftDvKTWdafBuuKtkJoadQljsejz() {} // Dummy constructor
			private ftDvKTWdafBuuKtkJoadQljsejz(IControllerTemplate parent, int id, string name, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D742B0-0x0000000185D743F0
			internal ftDvKTWdafBuuKtkJoadQljsejz(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY xAxis, UDauPmAdOcMEjsLbmuQqmkmgNY yAxis, UDauPmAdOcMEjsLbmuQqmkmgNY button) {} // 0x0000000185D74100-0x0000000185D742B0
		}
	
		internal sealed class XokzMhnPecGHJSJjzVwYBfGTKpa : yPzRqVcgcVcOvOJlFWoFIMAynfK, IControllerTemplateDPad // TypeDefIndex: 3668
		{
			// Properties
			public Vector2 JHgsNLxiAQVnmyfVeWejfTJocIu { get => default; } // 0x0000000185D736B0-0x0000000185D739E0 
			public Vector2 NckTuqeNamazETPgRISbxBNlOkT { get => default; } // 0x0000000185D73380-0x0000000185D736B0 
			public IControllerTemplateButton jLzkPNhiuocnwIjrKSJOBhjLctO { get => default; } // 0x0000000185D73260-0x0000000185D73380 
			public IControllerTemplateButton hkuJMtRBVjQBFhGxIosNxuQTIjK { get => default; } // 0x0000000185D73140-0x0000000185D73260 
			public IControllerTemplateButton oUdmHtHfuFVYNFhUxaMwMdwrzYx { get => default; } // 0x0000000185D72F00-0x0000000185D73020 
			public IControllerTemplateButton qGtLYeGRXSVpsrtOXzpqUDyhAdN { get => default; } // 0x0000000185D73020-0x0000000185D73140 
	
			// Constructors
			public XokzMhnPecGHJSJjzVwYBfGTKpa() {} // Dummy constructor
			private XokzMhnPecGHJSJjzVwYBfGTKpa(IControllerTemplate parent, int id, string name, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D72B80-0x0000000185D72CC0
			internal XokzMhnPecGHJSJjzVwYBfGTKpa(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY up, UDauPmAdOcMEjsLbmuQqmkmgNY right, UDauPmAdOcMEjsLbmuQqmkmgNY down, UDauPmAdOcMEjsLbmuQqmkmgNY left, UDauPmAdOcMEjsLbmuQqmkmgNY press) {} // 0x0000000185D72CC0-0x0000000185D72F00
		}
	
		internal sealed class KQCfaqwElyAxiDalHTbvQWqRsrXV : yPzRqVcgcVcOvOJlFWoFIMAynfK, IControllerTemplateThrottle // TypeDefIndex: 3669
		{
			// Properties
			public float JHgsNLxiAQVnmyfVeWejfTJocIu { get => default; } // 0x0000000185D6B210-0x0000000185D6B340 
			public float NckTuqeNamazETPgRISbxBNlOkT { get => default; } // 0x0000000185D6B0E0-0x0000000185D6B210 
			public IControllerTemplateAxis pbluGpIRWBBLvLxsblIOUUPvJLp { get => default; } // 0x0000000185D6AFC0-0x0000000185D6B0E0 
			public IControllerTemplateButton GUWWbOCMUJDVqGfvKJNcgWQiHLd { get => default; } // 0x0000000185D6AEA0-0x0000000185D6AFC0 
	
			// Constructors
			public KQCfaqwElyAxiDalHTbvQWqRsrXV() {} // Dummy constructor
			private KQCfaqwElyAxiDalHTbvQWqRsrXV(IControllerTemplate parent, int id, string name, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D6AC00-0x0000000185D6AD40
			internal KQCfaqwElyAxiDalHTbvQWqRsrXV(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY axis, UDauPmAdOcMEjsLbmuQqmkmgNY zeroDetentButton) {} // 0x0000000185D6AD40-0x0000000185D6AEA0
		}
	
		internal sealed class humcueBFfIOwlLXRMeWWHueKVJzo : yPzRqVcgcVcOvOJlFWoFIMAynfK, IControllerTemplateHat // TypeDefIndex: 3670
		{
			// Properties
			public Vector2 JHgsNLxiAQVnmyfVeWejfTJocIu { get => default; } // 0x0000000185D75BD0-0x0000000185D765D0 
			public Vector2 NckTuqeNamazETPgRISbxBNlOkT { get => default; } // 0x0000000185D752D0-0x0000000185D75BD0 
			public IControllerTemplateButton jLzkPNhiuocnwIjrKSJOBhjLctO { get => default; } // 0x0000000185D751B0-0x0000000185D752D0 
			public IControllerTemplateButton AJkzVFFllFqkhwuDhQPeCBCnGjTe { get => default; } // 0x0000000185D75060-0x0000000185D751B0 
			public IControllerTemplateButton hkuJMtRBVjQBFhGxIosNxuQTIjK { get => default; } // 0x0000000185D74E20-0x0000000185D74F40 
			public IControllerTemplateButton tJNzxmkCyMgadgrThnSURVtYhTc { get => default; } // 0x0000000185D74AC0-0x0000000185D74BE0 
			public IControllerTemplateButton oUdmHtHfuFVYNFhUxaMwMdwrzYx { get => default; } // 0x0000000185D74BE0-0x0000000185D74D00 
			public IControllerTemplateButton dMDVIfVAbukDCSxkaLiIgjeninJ { get => default; } // 0x0000000185D749A0-0x0000000185D74AC0 
			public IControllerTemplateButton qGtLYeGRXSVpsrtOXzpqUDyhAdN { get => default; } // 0x0000000185D74D00-0x0000000185D74E20 
			public IControllerTemplateButton UBxmexfxFFZofknWfxaohJiqRrg { get => default; } // 0x0000000185D74F40-0x0000000185D75060 
	
			// Constructors
			public humcueBFfIOwlLXRMeWWHueKVJzo() {} // Dummy constructor
			private humcueBFfIOwlLXRMeWWHueKVJzo(IControllerTemplate parent, int id, string name, QgSdyGzqsrxSGVEZPuwJASSKdjd[] elements) {} // 0x0000000185D74830-0x0000000185D749A0
			internal humcueBFfIOwlLXRMeWWHueKVJzo(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY up, UDauPmAdOcMEjsLbmuQqmkmgNY upRight, UDauPmAdOcMEjsLbmuQqmkmgNY right, UDauPmAdOcMEjsLbmuQqmkmgNY downRight, UDauPmAdOcMEjsLbmuQqmkmgNY down, UDauPmAdOcMEjsLbmuQqmkmgNY downLeft, UDauPmAdOcMEjsLbmuQqmkmgNY left, UDauPmAdOcMEjsLbmuQqmkmgNY upLeft) {} // 0x0000000185D74510-0x0000000185D74830
		}
	
		internal sealed class xDrAlRNlQTKnyzSBxtrQQjnKAPIJ : YGKhMizCnedpqehdtMmiwEvLoat, IControllerTemplateYoke // TypeDefIndex: 3671
		{
			// Properties
			public IControllerTemplateAxis XBWDUzcsRJpKCaZAYZelsKQOcCsF { get => default; } // 0x0000000185D78DD0-0x0000000185D78EF0 
			public IControllerTemplateAxis zucWjHjmmkNyjwKdfKQKicAQFHk { get => default; } // 0x0000000185D78CB0-0x0000000185D78DD0 
	
			// Constructors
			public xDrAlRNlQTKnyzSBxtrQQjnKAPIJ() {} // Dummy constructor
			internal xDrAlRNlQTKnyzSBxtrQQjnKAPIJ(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY rollAxis, UDauPmAdOcMEjsLbmuQqmkmgNY pitchAxis) {} // 0x0000000185D78B30-0x0000000185D78CB0
		}
	
		internal sealed class VykWFAhQVgeGyDqgzGsBBSVFqcFd : uxydodeweaeHWCGgEcCcmnfgWvV, IControllerTemplateStick6D // TypeDefIndex: 3672
		{
			// Constructors
			public VykWFAhQVgeGyDqgzGsBBSVFqcFd() {} // Dummy constructor
			internal VykWFAhQVgeGyDqgzGsBBSVFqcFd(IControllerTemplate parent, int id, string name, UDauPmAdOcMEjsLbmuQqmkmgNY positionX, UDauPmAdOcMEjsLbmuQqmkmgNY positionY, UDauPmAdOcMEjsLbmuQqmkmgNY positionZ, UDauPmAdOcMEjsLbmuQqmkmgNY rotationX, UDauPmAdOcMEjsLbmuQqmkmgNY rotationY, UDauPmAdOcMEjsLbmuQqmkmgNY rotationZ) {} // 0x0000000185D72660-0x0000000185D72900
		}
	
		internal class rlMFrkSNhflWEbbAbNShgGYIzlu // TypeDefIndex: 3673
		{
			// Fields
			public readonly Controller.Element nsrJcOgpcFdFnRaSgBMVkSZUgdlg; // 0x10
			public readonly IControllerElementTarget nCWCOIOOofbnfixPcuUIeRfVqGi; // 0x18
	
			// Properties
			public bool EMZbXVXPLuILqYgGuvFKlphsdbl { get => default; } // 0x0000000185D76DF0-0x0000000185D76F70 
			public bool WutNNBIWjxFJvQhrLiSPYtWXmXn { get => default; } // 0x0000000185D76BA0-0x0000000185D76DF0 
			public bool WtGthpECoDbOsHItqSaxlREzWkFv { get => default; } // 0x0000000185D77330-0x0000000185D77450 
			public bool XWcrUQihYipFwqpvjTfIOBKdjCL { get => default; } // 0x0000000185D77450-0x0000000185D77590 
			public float CZnVxHmgUjKMWBbQBIDPHMRbcIP { get => default; } // 0x0000000185D770F0-0x0000000185D77330 
			public float YVPjZamcZgjuSruKLDKojliZWaR { get => default; } // 0x0000000185D76F70-0x0000000185D770F0 
	
			// Constructors
			public rlMFrkSNhflWEbbAbNShgGYIzlu() {} // Dummy constructor
			public rlMFrkSNhflWEbbAbNShgGYIzlu(IControllerElementTarget target, Controller.Element element) {} // 0x0000000185D76B00-0x0000000185D76BA0
	
			// Methods
			public static rlMFrkSNhflWEbbAbNShgGYIzlu EacwNkMfYaHjbQRdeDfnuPOoebXI() => default; // 0x0000000185D76A70-0x0000000185D76B00
		}
	
		internal class NTQeamxZJcOeTxKdrraxwupmbcy // TypeDefIndex: 3674
		{
			// Fields
			public readonly Controller xwApvxwuWEivSrbItjIXHBzMlIz; // 0x10
			public readonly IHardwareControllerTemplateMap_Internal eWwksNGDfrYHnxOTpLfKlyDWcwJ; // 0x18
	
			// Constructors
			public NTQeamxZJcOeTxKdrraxwupmbcy() {} // Dummy constructor
			public NTQeamxZJcOeTxKdrraxwupmbcy(Controller controller, IHardwareControllerTemplateMap_Internal templateMap) {} // 0x0000000185D6B340-0x0000000185D6B430
		}
	
		// Constructors
		protected ControllerTemplate() {} // Dummy constructor
		protected ControllerTemplate(object payload) {} // 0x0000000185D63CC0-0x0000000185D63D90
		private ControllerTemplate(NTQeamxZJcOeTxKdrraxwupmbcy initializer) {} // 0x0000000185D61D50-0x0000000185D63CC0
	
		// Methods
		protected IControllerTemplateElement GetElement(int id) => default; // 0x0000000185D60FC0-0x0000000185D61320
		protected T GetElement<T>(int id)
			where T : class, IControllerTemplateElement => default;
		IControllerTemplateElement IControllerTemplate.GetElement(int param_000080c5) => default; // 0x0000000185D61540-0x0000000185D61620
		int IControllerTemplate.GetElementTargets(ControllerElementTarget param_000080c6, IList<ControllerTemplateElementTarget> param_000080c7) => default; // 0x0000000185D61410-0x0000000185D61540
		private int YRsQyehzCjjhjMwbaeUUUlHFftY(ControllerElementTarget param_000080c8, ref IList<ControllerTemplateElementTarget> param_000080c9) => default; // 0x0000000185D619C0-0x0000000185D61D50
		private static IList<rlMFrkSNhflWEbbAbNShgGYIzlu> tXXUUMTLbwnHOSduhUfnFtuSOum(Controller param_000080ca, IControllerTemplateAxisSource param_000080cb) => default; // 0x0000000185D63FA0-0x0000000185D64440
		private static IList<rlMFrkSNhflWEbbAbNShgGYIzlu> tXXUUMTLbwnHOSduhUfnFtuSOum(Controller param_000080cc, IControllerTemplateButtonSource param_000080cd) => default; // 0x0000000185D64440-0x0000000185D644D0
		private static IList<rlMFrkSNhflWEbbAbNShgGYIzlu> tXXUUMTLbwnHOSduhUfnFtuSOum(Controller param_000080ce, IControllerElementTarget param_000080cf) => default; // 0x0000000185D63E80-0x0000000185D63FA0
		private static UDauPmAdOcMEjsLbmuQqmkmgNY gnpVykynzFPsfLymEnAunGPAlzV(IControllerTemplate param_000080d0, ADictionary<int, IControllerTemplateElement> param_000080d1, int param_000080d2) => default; // 0x0000000185D63D90-0x0000000185D63E80
		private static UDauPmAdOcMEjsLbmuQqmkmgNY PewicdxVsQxhCAlIwGlsfgOPLTyg(IControllerTemplate param_000080d3, ADictionary<int, IControllerTemplateElement> param_000080d4, int param_000080d5) => default; // 0x0000000185D61320-0x0000000185D61410
	}
}
