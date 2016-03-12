// dllmain.h: 模块类的声明。

class CSimpleATLComModule : public ATL::CAtlDllModuleT< CSimpleATLComModule >
{
public :
	DECLARE_LIBID(LIBID_SimpleATLComLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_SIMPLEATLCOM, "{78CC5751-0A5A-48D6-8E13-238CB4AE1D89}")
};

extern class CSimpleATLComModule _AtlModule;
