// SimpleCom.h : CSimpleCom 的声明

#pragma once
#include "resource.h"       // 主符号



#include "SimpleATLCom_i.h"
#include "_ISimpleComEvents_CP.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Windows CE 平台(如不提供完全 DCOM 支持的 Windows Mobile 平台)上无法正确支持单线程 COM 对象。定义 _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA 可强制 ATL 支持创建单线程 COM 对象实现并允许使用其单线程 COM 对象实现。rgs 文件中的线程模型已被设置为“Free”，原因是该模型是非 DCOM Windows CE 平台支持的唯一线程模型。"
#endif

using namespace ATL;


// CSimpleCom

class ATL_NO_VTABLE CSimpleCom :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CSimpleCom, &CLSID_SimpleCom>,
	public IConnectionPointContainerImpl<CSimpleCom>,
	public CProxy_ISimpleComEvents<CSimpleCom>,
	public IDispatchImpl<ISimpleCom, &IID_ISimpleCom, &LIBID_SimpleATLComLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	CSimpleCom()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_SIMPLECOM)


BEGIN_COM_MAP(CSimpleCom)
	COM_INTERFACE_ENTRY(ISimpleCom)
	COM_INTERFACE_ENTRY(IDispatch)
	COM_INTERFACE_ENTRY(IConnectionPointContainer)
END_COM_MAP()

BEGIN_CONNECTION_POINT_MAP(CSimpleCom)
	CONNECTION_POINT_ENTRY(__uuidof(_ISimpleComEvents))
END_CONNECTION_POINT_MAP()


	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}
private:
	long m_lComMarks, m_lATLMarks, m_lTotalMarks;
	CComBSTR m_bstStudName;
public:



	STDMETHOD(Calculate)(VARIANT_BOOL a_bFireEvent, LONG* a_lTotalMarks);
	STDMETHOD(get_ComMarks)(LONG* pVal);
	STDMETHOD(put_ComMarks)(LONG newVal);
	STDMETHOD(get_AtlMarks)(LONG* pVal);
	STDMETHOD(put_AtlMarks)(LONG newVal);
	STDMETHOD(get_StudentName)(BSTR* pVal);
	STDMETHOD(put_StudentName)(BSTR newVal);
};

OBJECT_ENTRY_AUTO(__uuidof(SimpleCom), CSimpleCom)
