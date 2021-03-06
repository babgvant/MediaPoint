cd /d %~dp0
if not exist ".\output\" mkdir .\output
if not exist ".\output\obj\" mkdir .\output\obj
if not exist ".\output\obj\Release_Win32\" mkdir .\output\obj\Release_Win32
if not exist ".\output\obj\Release_Win32\system_2012\" mkdir .\output\obj\Release_Win32\system_2012
if not exist ".\output\obj\Release_Win32\Kasumi_2012\" mkdir .\output\obj\Release_Win32\Kasumi_2012


yasm -X vc -f Win32    -o       ".\output\obj\Release_Win32\system_2012\a_memory.obj" ".\src\thirdparty\VirtualDub\system\source\a_memory.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_bltrgb.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_bltrgb.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\system_2012\a_thunk.obj" ".\src\thirdparty\VirtualDub\system\source\a_thunk.asm"
yasm -X vc -f Win32    -o       ".\output\obj\Release_Win32\system_2012\a_memory.obj" ".\src\thirdparty\VirtualDub\system\source\a_memory.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_bltrgb2yuv_mmx.obj"  ".\src\thirdparty\VirtualDub\Kasumi\source\a_bltrgb2yuv_mmx.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_bltrgb_mmx.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_bltrgb_mmx.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_bltyuv2rgb_sse2.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_bltyuv2rgb_sse2.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_resample_mmx.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_resample_mmx.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_resample_sse41.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_resample_sse41.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_spanutils_isse.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_spanutils_isse.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_stretchrgb_mmx.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_stretchrgb_mmx.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_stretchrgb_point.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_stretchrgb_point.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_triblt_mmx.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_triblt_mmx.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_triblt_scalar.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_triblt_scalar.asm"
yasm -X vc -f Win32 -g cv8   -o ".\output\obj\Release_Win32\Kasumi_2012\a_triblt_sse2.obj" ".\src\thirdparty\VirtualDub\Kasumi\source\a_triblt_sse2.asm"
