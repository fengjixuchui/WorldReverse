/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class HeightMap // TypeDefIndex: 9332
	{
		// Fields
		protected int m_widthX; // 0x10
		protected int m_depthZ; // 0x14
		protected float[,] m_heights; // 0x18
		protected bool m_isPowerOf2; // 0x20
		protected float m_widthInvX; // 0x24
		protected float m_depthInvZ; // 0x28
		protected float m_statMinVal; // 0x2C
		protected float m_statMaxVal; // 0x30
		protected double m_statSumVals; // 0x38
		protected bool m_isDirty; // 0x40
		protected byte[] m_metaData; // 0x48
	
		// Properties
		public float this[int x, int z] { /* [IDTag] */ /* 0x00000001896F7C80-0x00000001896F7CC0 */ /* [XID] */ /* 0x00000001896F7C80-0x00000001896F7CC0 */ get => default; /* [XID] */ /* 0x0000000189702450-0x0000000189702490 */ /* [IDTag] */ /* 0x0000000189702450-0x0000000189702490 */ set {} } // 0x0000000185A010F0-0x0000000185A01610 0x0000000185A016F0-0x0000000185A01820
		public float this[float x, float z] { /* [IDTag] */ /* 0x000000018970C960-0x000000018970C9A0 */ /* [XID] */ /* 0x000000018970C960-0x000000018970C9A0 */ get => default; /* [XID] */ /* 0x0000000189716FE0-0x0000000189717020 */ /* [IDTag] */ /* 0x0000000189716FE0-0x0000000189717020 */ set {} } // 0x0000000185A01610-0x0000000185A016F0 0x0000000185A01820-0x0000000185A01990
	
		// Constructors
		public HeightMap() {} // 0x0000000185A01050-0x0000000185A010F0
		public HeightMap(int width, int depth) {} // 0x0000000185A009E0-0x0000000185A00B30
		public HeightMap(float[,] source) {} // 0x0000000185A00D40-0x0000000185A00EF0
		public HeightMap(float[,,] source, int slice) {} // 0x0000000185A00B30-0x0000000185A00D40
		public HeightMap(int[,] source) {} // 0x0000000185A007F0-0x0000000185A009E0
		public HeightMap(HeightMap source) {} // 0x0000000185A005F0-0x0000000185A007F0
		public HeightMap(string sourceFile) {} // 0x0000000185A00FA0-0x0000000185A01050
		public HeightMap(byte[] sourceBytes) {} // 0x0000000185A00EF0-0x0000000185A00FA0
	
		// Methods
		// [XID] // 0x000000018991D3B0-0x000000018991D3D0
		public int Width() => default; // 0x0000000185A00550-0x0000000185A005F0
		// [XID] // 0x0000000189673CD0-0x0000000189673CF0
		public int Depth() => default; // 0x00000001859F8C20-0x00000001859F8CC0
		// [XID] // 0x000000018967B4E0-0x000000018967B500
		public float MinVal() => default; // 0x00000001859FE090-0x00000001859FE140
		// [XID] // 0x0000000189B57DB0-0x0000000189B57DD0
		public float MaxVal() => default; // 0x00000001859FDFE0-0x00000001859FE090
		// [XID] // 0x000000018968A840-0x000000018968A860
		public double SumVal() => default; // 0x0000000185A00280-0x0000000185A00330
		// [XID] // 0x0000000189692680-0x00000001896926A0
		public int GetBufferSize() => default; // 0x00000001859FC0D0-0x00000001859FC180
		// [XID] // 0x0000000189AF4590-0x0000000189AF45B0
		public byte[] GetMetaData() => default; // 0x00000001859FC700-0x00000001859FC7A0
		// [XID] // 0x0000000189755120-0x0000000189755140
		public bool IsDirty() => default; // 0x00000001859FD520-0x00000001859FD5C0
		// [XID] // 0x00000001896A8330-0x00000001896A8350
		public void SetDirty(bool dirty = true /* Metadata: 0x00AE5761 */) {} // 0x00000001859FEEC0-0x00000001859FEF70
		// [XID] // 0x00000001896AF6F0-0x00000001896AF710
		public void ClearDirty() {} // 0x00000001859F86E0-0x00000001859F8780
		// [XID] // 0x00000001896687C0-0x00000001896687E0
		public void SetMetaData(byte[] metadata) {} // 0x00000001859FF360-0x00000001859FF470
		// [XID] // 0x000000018964DEE0-0x000000018964DF00
		public float[,] Heights() => default; // 0x00000001859FD340-0x00000001859FD3E0
		// [XID] // 0x00000001896C58F0-0x00000001896C5910
		public float[] Heights1D() => default; // 0x00000001859FD230-0x00000001859FD340
		// [IDTag] // 0x00000001896CCF60-0x00000001896CCFA0
		// [XID] // 0x00000001896CCF60-0x00000001896CCFA0
		public void SetHeights(float[] heights) {} // 0x00000001859FF200-0x00000001859FF360
		// [IDTag] // 0x00000001896D7400-0x00000001896D7440
		// [XID] // 0x00000001896D7400-0x00000001896D7440
		public void SetHeights(float[,] heights) {} // 0x00000001859FF090-0x00000001859FF200
		// [XID] // 0x0000000189A38AB0-0x0000000189A38AD0
		public float GetSafeHeight(int x, int z) => default; // 0x00000001859FC920-0x00000001859FCA60
		// [XID] // 0x0000000189B84CF0-0x0000000189B84D10
		public void SetSafeHeight(int x, int z, float height) {} // 0x00000001859FF5C0-0x00000001859FF710
		// [XID] // 0x000000018994DB60-0x000000018994DB80
		protected float GetInterpolatedHeight(float x, float z) => default; // 0x00000001859FC430-0x00000001859FC700
		// [XID] // 0x000000018995B0F0-0x000000018995B110
		public HeightMap SetHeight(float height) => default; // 0x00000001859FEF70-0x00000001859FF090
		// [XID] // 0x0000000189728DC0-0x0000000189728DE0
		public void GetHeightRange(ref float minHeight, ref float maxHeight) {} // 0x00000001859FC2F0-0x00000001859FC430
		// [IDTag] // 0x00000001897307B0-0x00000001897307F0
		// [XID] // 0x00000001897307B0-0x00000001897307F0
		public float GetSlope(int x, int z) => default; // 0x00000001859FCF50-0x00000001859FD140
		// [IDTag] // 0x000000018973ADB0-0x000000018973ADF0
		// [XID] // 0x000000018973ADB0-0x000000018973ADF0
		public float GetSlope(float x, float z) => default; // 0x00000001859FCD80-0x00000001859FCF50
		// [XID] // 0x00000001895EA990-0x00000001895EA9B0
		public float GetSlope_a(float x, float z) => default; // 0x00000001859FCB90-0x00000001859FCD80
		// [XID] // 0x000000018974D2B0-0x000000018974D2D0
		public float GetBaseLevel() => default; // 0x00000001859FBE70-0x00000001859FC0D0
		// [XID] // 0x0000000189A393D0-0x0000000189A393F0
		public bool HasData() => default; // 0x00000001859FD140-0x00000001859FD230
		// [XID] // 0x000000018975BB70-0x000000018975BB90
		public float[] GetRow(int rowX) => default; // 0x00000001859FC7A0-0x00000001859FC920
		// [XID] // 0x0000000189A891D0-0x0000000189A891F0
		public void SetRow(int rowX, float[] values) {} // 0x00000001859FF470-0x00000001859FF5C0
		// [XID] // 0x000000018980E5B0-0x000000018980E5D0
		public float[] GetColumn(int columnZ) => default; // 0x00000001859FC180-0x00000001859FC2F0
		// [XID] // 0x0000000189875D80-0x0000000189875DA0
		public void SetColumn(int columnZ, float[] values) {} // 0x00000001859FED70-0x00000001859FEEC0
		// [XID] // 0x0000000189779A00-0x0000000189779A20
		public void Reset() {} // 0x00000001859FEAB0-0x00000001859FEBC0
		// [XID] // 0x00000001897813E0-0x0000000189781400
		public void UpdateStats() {} // 0x0000000185A00430-0x0000000185A00550
		// [XID] // 0x00000001897888A0-0x00000001897888C0
		public HeightMap Smooth(int iterations) => default; // 0x00000001859FFA30-0x00000001859FFC50
		// [XID] // 0x00000001896E0DB0-0x00000001896E0DD0
		public HeightMap SmoothRadius(int radius) => default; // 0x00000001859FF710-0x00000001859FFA30
		// [XID] // 0x00000001896E8060-0x00000001896E8080
		public HeightMap GetSlopeMap() => default; // 0x00000001859FCA60-0x00000001859FCB90
		// [XID] // 0x000000018969EB30-0x000000018969EB50
		public HeightMap Copy(HeightMap heightMap) => default; // 0x00000001859F8AA0-0x00000001859F8C20
		// [XID] // 0x00000001897A6C40-0x00000001897A6C60
		public HeightMap CopyClamped(HeightMap heightMap, float min, float max) => default; // 0x00000001859F88E0-0x00000001859F8AA0
		// [XID] // 0x0000000189AB7FA0-0x0000000189AB7FC0
		public HeightMap Duplicate() => default; // 0x00000001859F9BD0-0x00000001859F9CA0
		// [XID] // 0x00000001897B6550-0x00000001897B6570
		public HeightMap Invert() => default; // 0x00000001859FD3E0-0x00000001859FD520
		// [XID] // 0x00000001897BE2A0-0x00000001897BE2C0
		public HeightMap Flip() => default; // 0x00000001859FBC80-0x00000001859FBE70
		// [XID] // 0x00000001897C59A0-0x00000001897C59C0
		public HeightMap Normalise() => default; // 0x00000001859FE770-0x00000001859FE930
		// [IDTag] // 0x00000001897CD080-0x00000001897CD0C0
		// [XID] // 0x00000001897CD080-0x00000001897CD0C0
		public HeightMap Erode(float min_threshold, float max_threshold, int iterations) => default; // 0x00000001859FB3F0-0x00000001859FB910
		// [IDTag] // 0x00000001897D78B0-0x00000001897D78F0
		// [XID] // 0x00000001897D78B0-0x00000001897D78F0
		public HeightMap Erode(float talus, int iterations) => default; // 0x00000001859FB910-0x00000001859FBC80
		// [XID] // 0x00000001897E1FD0-0x00000001897E1FF0
		public HeightMap ErodeThermal(float talus, int iterations) => default; // 0x00000001859FB080-0x00000001859FB3F0
		// [XID] // 0x00000001897E97D0-0x00000001897E97F0
		public HeightMap ErodeHydraulic(int iterations, HeightMap rainMap, int rainFrequency, float sedimentDisolveRate) => default; // 0x00000001859FAAA0-0x00000001859FB080
		// [XID] // 0x00000001897F1440-0x00000001897F1460
		public HeightMap ErodeHydraulicFaster(int iterations, HeightMap rainMap, int rainFrequency, float sedimentDisolveRate) => default; // 0x00000001859FA3A0-0x00000001859FAAA0
		// [XID] // 0x0000000189B932F0-0x0000000189B93310
		public HeightMap ErodeHydraulicFasterExperimental(int iterations, HeightMap rainMap, int rainFrequency, float sedimentDisolveRate) => default; // 0x00000001859F9CA0-0x00000001859FA3A0
		// [IDTag] // 0x0000000189800220-0x0000000189800260
		// [XID] // 0x0000000189800220-0x0000000189800260
		public HeightMap Add(float value) => default; // 0x00000001859F8500-0x00000001859F8610
		// [IDTag] // 0x000000018980A820-0x000000018980A860
		// [XID] // 0x000000018980A820-0x000000018980A860
		public HeightMap Add(HeightMap heightMap) => default; // 0x00000001859F8370-0x00000001859F8500
		// [IDTag] // 0x0000000189814CB0-0x0000000189814CF0
		// [XID] // 0x0000000189814CB0-0x0000000189814CF0
		public HeightMap AddClamped(float value, float min, float max) => default; // 0x00000001859F7FE0-0x00000001859F8170
		// [IDTag] // 0x000000018981F870-0x000000018981F8B0
		// [XID] // 0x000000018981F870-0x000000018981F8B0
		public HeightMap AddClamped(HeightMap heightMap, float min, float max) => default; // 0x00000001859F8170-0x00000001859F8370
		// [IDTag] // 0x0000000189829D50-0x0000000189829D90
		// [XID] // 0x0000000189829D50-0x0000000189829D90
		public HeightMap Subtract(float value) => default; // 0x0000000185A00170-0x0000000185A00280
		// [IDTag] // 0x0000000189834440-0x0000000189834480
		// [XID] // 0x0000000189834440-0x0000000189834480
		public HeightMap Subtract(HeightMap heightMap) => default; // 0x00000001859FFFE0-0x0000000185A00170
		// [IDTag] // 0x000000018983E940-0x000000018983E980
		// [XID] // 0x000000018983E940-0x000000018983E980
		public HeightMap SubtractClamped(float value, float min, float max) => default; // 0x00000001859FFC50-0x00000001859FFDE0
		// [IDTag] // 0x0000000189848AE0-0x0000000189848B20
		// [XID] // 0x0000000189848AE0-0x0000000189848B20
		public HeightMap SubtractClamped(HeightMap heightMap, float min, float max) => default; // 0x00000001859FFDE0-0x00000001859FFFE0
		// [IDTag] // 0x0000000189852CF0-0x0000000189852D30
		// [XID] // 0x0000000189852CF0-0x0000000189852D30
		public HeightMap Multiply(float value) => default; // 0x00000001859FE660-0x00000001859FE770
		// [IDTag] // 0x000000018985D1E0-0x000000018985D220
		// [XID] // 0x000000018985D1E0-0x000000018985D220
		public HeightMap Multiply(HeightMap heightMap) => default; // 0x00000001859FE4D0-0x00000001859FE660
		// [IDTag] // 0x0000000189867A70-0x0000000189867AB0
		// [XID] // 0x0000000189867A70-0x0000000189867AB0
		public HeightMap MultiplyClamped(float value, float min, float max) => default; // 0x00000001859FE340-0x00000001859FE4D0
		// [IDTag] // 0x0000000189871FB0-0x0000000189871FF0
		// [XID] // 0x0000000189871FB0-0x0000000189871FF0
		public HeightMap MultiplyClamped(HeightMap heightMap, float min, float max) => default; // 0x00000001859FE140-0x00000001859FE340
		// [IDTag] // 0x000000018987C7E0-0x000000018987C820
		// [XID] // 0x000000018987C7E0-0x000000018987C820
		public HeightMap Divide(float value) => default; // 0x00000001859F91E0-0x00000001859F92F0
		// [IDTag] // 0x0000000189886C80-0x0000000189886CC0
		// [XID] // 0x0000000189886C80-0x0000000189886CC0
		public HeightMap Divide(HeightMap heightMap) => default; // 0x00000001859F9050-0x00000001859F91E0
		// [IDTag] // 0x0000000189890E40-0x0000000189890E80
		// [XID] // 0x0000000189890E40-0x0000000189890E80
		public HeightMap DivideClamped(float value, float min, float max) => default; // 0x00000001859F8EC0-0x00000001859F9050
		// [IDTag] // 0x000000018989B590-0x000000018989B5D0
		// [XID] // 0x000000018989B590-0x000000018989B5D0
		public HeightMap DivideClamped(HeightMap heightMap, float min, float max) => default; // 0x00000001859F8CC0-0x00000001859F8EC0
		// [XID] // 0x0000000189769F70-0x0000000189769F90
		public float Sum() => default; // 0x0000000185A00330-0x0000000185A00430
		// [XID] // 0x0000000189778EE0-0x0000000189778F00
		public float Average() => default; // 0x00000001859F8610-0x00000001859F86E0
		// [XID] // 0x0000000189787DC0-0x0000000189787DE0
		public HeightMap Power(float exponent) => default; // 0x00000001859FE930-0x00000001859FEAB0
		// [XID] // 0x00000001898BC350-0x00000001898BC370
		public HeightMap Contrast(float contrast) => default; // 0x00000001859F8780-0x00000001859F88E0
		// [XID] // 0x00000001898C3710-0x00000001898C3730
		public void SaveToBinaryFile(string fileName) {} // 0x00000001859FEBC0-0x00000001859FED70
		// [XID] // 0x0000000189A1A150-0x0000000189A1A170
		public void LoadFromBinaryFile(string fileName) {} // 0x00000001859FD5C0-0x00000001859FD900
		// [XID] // 0x00000001898D2840-0x00000001898D2860
		public void LoadFromByteArray(byte[] source) {} // 0x00000001859FD900-0x00000001859FDBF0
		// [XID] // 0x0000000189A4CE80-0x0000000189A4CEA0
		public void LoadFromRawFile(string fileName) {} // 0x00000001859FDBF0-0x00000001859FDFE0
		// [XID] // 0x00000001898E1DB0-0x00000001898E1DD0
		public void DumpMap(float scaleValue, int precision, string spacer, bool flip) {} // 0x00000001859F95C0-0x00000001859F9900
		// [XID] // 0x00000001898E9AB0-0x00000001898E9AD0
		public void DumpRow(int rowX, float scaleValue, int precision, string spacer) {} // 0x00000001859F9900-0x00000001859F9BD0
		// [XID] // 0x00000001898F0F20-0x00000001898F0F40
		public void DumpColumn(int columnZ, float scaleValue, int precision, string spacer) {} // 0x00000001859F92F0-0x00000001859F95C0
	}
}
