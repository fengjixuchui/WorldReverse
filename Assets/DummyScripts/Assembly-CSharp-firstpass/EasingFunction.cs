/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class EasingFunction // TypeDefIndex: 8986
{
	// Fields
	private const double NATURAL_LOG_OF_2 = 0.6931471824645996; // Metadata: 0x00AE4F91

	// Nested types
	public enum Ease // TypeDefIndex: 8987
	{
		EaseInQuad = 0,
		EaseOutQuad = 1,
		EaseInOutQuad = 2,
		EaseInCubic = 3,
		EaseOutCubic = 4,
		EaseInOutCubic = 5,
		EaseInQuart = 6,
		EaseOutQuart = 7,
		EaseInOutQuart = 8,
		EaseInQuint = 9,
		EaseOutQuint = 10,
		EaseInOutQuint = 11,
		EaseInSine = 12,
		EaseOutSine = 13,
		EaseInOutSine = 14,
		EaseInExpo = 15,
		EaseOutExpo = 16,
		EaseInOutExpo = 17,
		EaseInCirc = 18,
		EaseOutCirc = 19,
		EaseInOutCirc = 20,
		Linear = 21,
		Spring = 22,
		EaseInBounce = 23,
		EaseOutBounce = 24,
		EaseInOutBounce = 25,
		EaseInBack = 26,
		EaseOutBack = 27,
		EaseInOutBack = 28,
		EaseInElastic = 29,
		EaseOutElastic = 30,
		EaseInOutElastic = 31
	}

	public delegate double Function(double s, double e, double v); // TypeDefIndex: 8988; 0x00000001863BD370-0x00000001863BD570

	public delegate double FunctionValue(double v); // TypeDefIndex: 8989; 0x00000001863BCFE0-0x00000001863BD170

	// Methods
	public static double Linear(double start, double end, double value) => default; // 0x0000000186037240-0x00000001860372F0
	public static double Linear(double value) => default; // 0x00000001860371E0-0x0000000186037240
	public static double Spring(double start, double end, double value) => default; // 0x00000001860374F0-0x0000000186037630
	public static double Spring(double value) => default; // 0x0000000186037630-0x0000000186037750
	public static double EaseInQuad(double start, double end, double value) => default; // 0x0000000186032BC0-0x0000000186032C50
	public static double EaseInQuad(double value) => default; // 0x0000000186032B60-0x0000000186032BC0
	public static double EaseOutQuad(double start, double end, double value) => default; // 0x0000000186033FD0-0x0000000186034070
	public static double EaseOutQuad(double value) => default; // 0x0000000186033F50-0x0000000186033FD0
	public static double EaseInOutQuad(double start, double end, double value) => default; // 0x0000000186032320-0x0000000186032410
	public static double EaseInOutQuad(double value) => default; // 0x0000000186032270-0x0000000186032320
	public static double EaseInCubic(double start, double end, double value) => default; // 0x0000000186030C90-0x0000000186030D20
	public static double EaseInCubic(double value) => default; // 0x0000000186030D20-0x0000000186030D90
	public static double EaseOutCubic(double start, double end, double value) => default; // 0x0000000186033940-0x0000000186033A00
	public static double EaseOutCubic(double value) => default; // 0x0000000186033A00-0x0000000186033A80
	public static double EaseInOutCubic(double start, double end, double value) => default; // 0x0000000186031A00-0x0000000186031AF0
	public static double EaseInOutCubic(double value) => default; // 0x0000000186031AF0-0x0000000186031BA0
	public static double EaseInQuart(double start, double end, double value) => default; // 0x0000000186032D60-0x0000000186032DF0
	public static double EaseInQuart(double value) => default; // 0x0000000186032CE0-0x0000000186032D60
	public static double EaseOutQuart(double start, double end, double value) => default; // 0x00000001860341A0-0x0000000186034260
	public static double EaseOutQuart(double value) => default; // 0x0000000186034110-0x00000001860341A0
	public static double EaseInOutQuart(double start, double end, double value) => default; // 0x0000000186032590-0x0000000186032690
	public static double EaseInOutQuart(double value) => default; // 0x00000001860324D0-0x0000000186032590
	public static double EaseInQuint(double start, double end, double value) => default; // 0x0000000186032E90-0x0000000186032F30
	public static double EaseInQuint(double value) => default; // 0x0000000186032F30-0x0000000186032FB0
	public static double EaseOutQuint(double start, double end, double value) => default; // 0x0000000186034390-0x0000000186034450
	public static double EaseOutQuint(double value) => default; // 0x0000000186034300-0x0000000186034390
	public static double EaseInOutQuint(double start, double end, double value) => default; // 0x0000000186032800-0x0000000186032900
	public static double EaseInOutQuint(double value) => default; // 0x0000000186032740-0x0000000186032800
	public static double EaseInSine(double start, double end, double value) => default; // 0x00000001860330D0-0x0000000186033180
	public static double EaseInSine(double value) => default; // 0x0000000186033050-0x00000001860330D0
	public static double EaseOutSine(double start, double end, double value) => default; // 0x0000000186034560-0x0000000186034600
	public static double EaseOutSine(double value) => default; // 0x00000001860344F0-0x0000000186034560
	public static double EaseInOutSine(double start, double end, double value) => default; // 0x0000000186032A20-0x0000000186032AD0
	public static double EaseInOutSine(double value) => default; // 0x00000001860329A0-0x0000000186032A20
	public static double EaseInExpo(double start, double end, double value) => default; // 0x0000000186031080-0x0000000186031130
	public static double EaseInExpo(double value) => default; // 0x0000000186031000-0x0000000186031080
	public static double EaseOutExpo(double start, double end, double value) => default; // 0x0000000186033E00-0x0000000186033EB0
	public static double EaseOutExpo(double value) => default; // 0x0000000186033D70-0x0000000186033E00
	public static double EaseInOutExpo(double start, double end, double value) => default; // 0x0000000186031FE0-0x0000000186032100
	public static double EaseInOutExpo(double value) => default; // 0x0000000186032100-0x00000001860321C0
	public static double EaseInCirc(double start, double end, double value) => default; // 0x0000000186030B50-0x0000000186030C00
	public static double EaseInCirc(double value) => default; // 0x0000000186030AD0-0x0000000186030B50
	public static double EaseOutCirc(double start, double end, double value) => default; // 0x00000001860337F0-0x00000001860338A0
	public static double EaseOutCirc(double value) => default; // 0x0000000186033770-0x00000001860337F0
	public static double EaseInOutCirc(double start, double end, double value) => default; // 0x0000000186031850-0x0000000186031950
	public static double EaseInOutCirc(double value) => default; // 0x0000000186031790-0x0000000186031850
	public static double EaseInBounce(double start, double end, double value) => default; // 0x0000000186030970-0x0000000186030A30
	public static double EaseInBounce(double value) => default; // 0x00000001860308E0-0x0000000186030970
	public static double EaseOutBounce(double start, double end, double value) => default; // 0x0000000186033480-0x00000001860335C0
	public static double EaseOutBounce(double value) => default; // 0x00000001860335C0-0x00000001860336C0
	public static double EaseInOutBounce(double start, double end, double value) => default; // 0x00000001860314F0-0x00000001860315F0
	public static double EaseInOutBounce(double value) => default; // 0x00000001860315F0-0x00000001860316B0
	public static double EaseInBack(double start, double end, double value) => default; // 0x0000000186030790-0x0000000186030830
	public static double EaseInBack(double value) => default; // 0x0000000186030710-0x0000000186030790
	public static double EaseOutBack(double start, double end, double value) => default; // 0x0000000186033240-0x0000000186033310
	public static double EaseOutBack(double value) => default; // 0x0000000186033310-0x00000001860333A0
	public static double EaseInOutBack(double start, double end, double value) => default; // 0x0000000186031240-0x0000000186031340
	public static double EaseInOutBack(double value) => default; // 0x0000000186031340-0x0000000186031410
	public static double EaseInElastic(double start, double end, double value) => default; // 0x0000000186030E40-0x0000000186030F50
	public static double EaseOutElastic(double start, double end, double value) => default; // 0x0000000186033BB0-0x0000000186033CC0
	public static double EaseInOutElastic(double start, double end, double value) => default; // 0x0000000186031D80-0x0000000186031EF0
	public static double LinearD(double start, double end, double value) => default; // 0x0000000186037170-0x00000001860371E0
	public static double EaseInQuadD(double start, double end, double value) => default; // 0x0000000186032AD0-0x0000000186032B60
	public static double EaseOutQuadD(double start, double end, double value) => default; // 0x0000000186033EB0-0x0000000186033F50
	public static double EaseInOutQuadD(double start, double end, double value) => default; // 0x00000001860321C0-0x0000000186032270
	public static double EaseInCubicD(double start, double end, double value) => default; // 0x0000000186030C00-0x0000000186030C90
	public static double EaseOutCubicD(double start, double end, double value) => default; // 0x00000001860338A0-0x0000000186033940
	public static double EaseInOutCubicD(double start, double end, double value) => default; // 0x0000000186031950-0x0000000186031A00
	public static double EaseInQuartD(double start, double end, double value) => default; // 0x0000000186032C50-0x0000000186032CE0
	public static double EaseOutQuartD(double start, double end, double value) => default; // 0x0000000186034070-0x0000000186034110
	public static double EaseInOutQuartD(double start, double end, double value) => default; // 0x0000000186032410-0x00000001860324D0
	public static double EaseInQuintD(double start, double end, double value) => default; // 0x0000000186032DF0-0x0000000186032E90
	public static double EaseOutQuintD(double start, double end, double value) => default; // 0x0000000186034260-0x0000000186034300
	public static double EaseInOutQuintD(double start, double end, double value) => default; // 0x0000000186032690-0x0000000186032740
	public static double EaseInSineD(double start, double end, double value) => default; // 0x0000000186032FB0-0x0000000186033050
	public static double EaseOutSineD(double start, double end, double value) => default; // 0x0000000186034450-0x00000001860344F0
	public static double EaseInOutSineD(double start, double end, double value) => default; // 0x0000000186032900-0x00000001860329A0
	public static double EaseInExpoD(double start, double end, double value) => default; // 0x0000000186030F50-0x0000000186031000
	public static double EaseOutExpoD(double start, double end, double value) => default; // 0x0000000186033CC0-0x0000000186033D70
	public static double EaseInOutExpoD(double start, double end, double value) => default; // 0x0000000186031EF0-0x0000000186031FE0
	public static double EaseInCircD(double start, double end, double value) => default; // 0x0000000186030A30-0x0000000186030AD0
	public static double EaseOutCircD(double start, double end, double value) => default; // 0x00000001860336C0-0x0000000186033770
	public static double EaseInOutCircD(double start, double end, double value) => default; // 0x00000001860316B0-0x0000000186031790
	public static double EaseInBounceD(double start, double end, double value) => default; // 0x0000000186030830-0x00000001860308E0
	public static double EaseOutBounceD(double start, double end, double value) => default; // 0x00000001860333A0-0x0000000186033480
	public static double EaseInOutBounceD(double start, double end, double value) => default; // 0x0000000186031410-0x00000001860314F0
	public static double EaseInBackD(double start, double end, double value) => default; // 0x0000000186030670-0x0000000186030710
	public static double EaseOutBackD(double start, double end, double value) => default; // 0x0000000186033180-0x0000000186033240
	public static double EaseInOutBackD(double start, double end, double value) => default; // 0x0000000186031130-0x0000000186031240
	public static double EaseInElasticD(double start, double end, double value) => default; // 0x0000000186030D90-0x0000000186030E40
	public static double EaseOutElasticD(double start, double end, double value) => default; // 0x0000000186033A80-0x0000000186033BB0
	public static double EaseInOutElasticD(double start, double end, double value) => default; // 0x0000000186031BA0-0x0000000186031D80
	public static double SpringD(double start, double end, double value) => default; // 0x00000001860372F0-0x00000001860374F0
	public static Function GetEasingFunction(Ease easingFunction) => default; // 0x00000001860362E0-0x0000000186037170
	public static FunctionValue GetEasingFunctionValue(Ease easingFunction) => default; // 0x0000000186035520-0x00000001860362E0
	public static Function GetEasingFunctionDerivative(Ease easingFunction) => default; // 0x0000000186034600-0x0000000186035520
}

