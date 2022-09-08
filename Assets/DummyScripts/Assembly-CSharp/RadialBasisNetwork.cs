/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RadialBasisNetwork // TypeDefIndex: 32159
{
	// Fields
	public double[,] Centers; // 0x10
	public double[,] W; // 0x18
	public double[] B; // 0x20
	public int M; // 0x28
	public int N; // 0x2C
	public int Y; // 0x30
	public double[] Radius; // 0x38
	public double spread; // 0x40

	// Constructors
	public RadialBasisNetwork() {} // Dummy constructor
	public RadialBasisNetwork(int M0, int N0, int Y0, double[,] inputCenters, double[,] inputW, double[] inputB) {} // 0x0000000181D18E30-0x0000000181D18EF0
	public RadialBasisNetwork(int M0, int N0, int Y0, double[,] inputCenters, double[,] inputW, double[] inputB, double inputSpread) {} // 0x0000000181D18EF0-0x0000000181D18FC0

	// Methods
	// [XID] // 0x0000000189736AD0-0x0000000189736AF0
	public void NetOutput(double[] inputs, ref double[] outputs) {} // 0x0000000181D18150-0x0000000181D182B0
	// [XID] // 0x000000018973E700-0x000000018973E720
	private void ComputeRadius(double[] inputs) {} // 0x0000000181D18830-0x0000000181D18B50
	// [XID] // 0x00000001897459E0-0x0000000189745A00
	public void SetNetWorkSpread(double inputSpread) {} // 0x0000000181D18D80-0x0000000181D18E30
	// [XID] // 0x000000018974D4A0-0x000000018974D4C0
	private void CombineWeights(ref double[] outputs) {} // 0x0000000181D18B50-0x0000000181D18D80
	// [IDTag] // 0x0000000189754B30-0x0000000189754B70
	// [XID] // 0x0000000189754B30-0x0000000189754B70
	private void InstanceParameter(double[,] inputCenters, double[,] inputW, double[] inputB) {} // 0x0000000181D18580-0x0000000181D18830
	// [IDTag] // 0x000000018975F130-0x000000018975F170
	// [XID] // 0x000000018975F130-0x000000018975F170
	private void InstanceParameter(double[] inputCenters, double[] inputW, double[] inputB) {} // 0x0000000181D182B0-0x0000000181D18580
}

