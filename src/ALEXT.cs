#region License
/* OpenAL# - C# Wrapper for OpenAL Soft
 *
 * Copyright (c) 2014-2015 Ethan Lee.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */
#endregion

#region Using Statements
using System;
using System.Runtime.InteropServices;
#endregion

namespace OpenAL
{
	public static class ALEXT
	{
		private const string nativeLibName = "soft_oal.dll";

		/* TODO: All OpenAL Soft extensions! Complete as needed. */

		/* typedef int ALenum */
		public const int AL_FORMAT_MONO_FLOAT32 =		0x10010;
		public const int AL_FORMAT_STEREO_FLOAT32 =		0x10011;

		public const int AL_LOOP_POINTS_SOFT =			0x2015;

		public const int AL_UNPACK_BLOCK_ALIGNMENT_SOFT =	0x200C;
		public const int AL_PACK_BLOCK_ALIGNMENT_SOFT =		0x200D;

		public const int AL_FORMAT_MONO_MSADPCM_SOFT =		0x1302;
		public const int AL_FORMAT_STEREO_MSADPCM_SOFT =	0x1303;

		public const int AL_BYTE_SOFT =				0x1400;
		public const int AL_SHORT_SOFT =			0x1402;
		public const int AL_FLOAT_SOFT =			0x1406;

		public const int AL_MONO_SOFT =				0x1500;
		public const int AL_STEREO_SOFT =			0x1501;

		public const int AL_GAIN_LIMIT_SOFT =			0x200E;

		// HRTF related constants
		public const int AL_STEREO_ANGLES =                     0x1030;
		public const int ALC_HRTF_SOFT =                        0x1992;
		public const int ALC_DONT_CARE_SOFT =                   0x0002;
		public const int ALC_HRTF_STATUS_SOFT =                 0x1993;
		public const int ALC_HRTF_DISABLED_SOFT =               0x0000;
		public const int ALC_HRTF_ENABLED_SOFT =                0x0001;
		public const int ALC_HRTF_DENIED_SOFT =                 0x0002;
		public const int ALC_HRTF_REQUIRED_SOFT =               0x0003;
		public const int ALC_HRTF_HEADPHONES_DETECTED_SOFT =    0x0004;
		public const int ALC_HRTF_UNSUPPORTED_FORMAT_SOFT =     0x0005;
		public const int ALC_NUM_HRTF_SPECIFIERS_SOFT =         0x1994;
		public const int ALC_HRTF_SPECIFIER_SOFT =              0x1995;
		public const int ALC_HRTF_ID_SOFT =                     0x1996;
 
		// Spacializing constants
		public const int AL_SOURCE_SPATIALIZE_SOFT =            0x1214;
		public const int AL_AUTO_SOFT =                         0x0002;

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void alGetBufferSamplesSOFT(
			uint buffer,
			int offset,
			int samples,
			int channels,
			int type,
			IntPtr data
		);

		// HRTF related method signatures        
		[DllImport(nativeLibName, EntryPoint = "alcGetStringiSOFT", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_alcGetStringiSOFT(IntPtr device, int param, int index);
		public static string alcGetStringiSOFT(IntPtr device, int param, int index)
		{
			return Marshal.PtrToStringAnsi(INTERNAL_alcGetStringiSOFT(device, param, index));
		}
       
		[DllImport(nativeLibName, EntryPoint = "alcResetDeviceSOFT", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool alcResetDeviceSoft(IntPtr device, int[] attribs);
	}
}
