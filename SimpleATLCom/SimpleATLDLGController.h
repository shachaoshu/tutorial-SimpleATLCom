// SimpleATLDLGController.h : CSimpleATLDLGController ������

#pragma once
#include "resource.h"       // ������



#include "SimpleATLCom_i.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Windows CE ƽ̨(�粻�ṩ��ȫ DCOM ֧�ֵ� Windows Mobile ƽ̨)���޷���ȷ֧�ֵ��߳� COM ���󡣶��� _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA ��ǿ�� ATL ֧�ִ������߳� COM ����ʵ�ֲ�����ʹ���䵥�߳� COM ����ʵ�֡�rgs �ļ��е��߳�ģ���ѱ�����Ϊ��Free����ԭ���Ǹ�ģ���Ƿ� DCOM Windows CE ƽ̨֧�ֵ�Ψһ�߳�ģ�͡�"
#endif

using namespace ATL;


// CSimpleATLDLGController

class ATL_NO_VTABLE CSimpleATLDLGController :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CSimpleATLDLGController, &CLSID_SimpleATLDLGController>,
	public IDispatchImpl<ISimpleATLDLGController, &IID_ISimpleATLDLGController, &LIBID_SimpleATLComLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	CSimpleATLDLGController()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_SIMPLEATLDLGCONTROLLER)


BEGIN_COM_MAP(CSimpleATLDLGController)
	COM_INTERFACE_ENTRY(ISimpleATLDLGController)
	COM_INTERFACE_ENTRY(IDispatch)
END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

public:

	STDMETHOD(InvokeDialog)(void);

	STDMETHOD(InvokeDialog2)();
	STDMETHOD(InvokeDialog3)();
};

OBJECT_ENTRY_AUTO(__uuidof(SimpleATLDLGController), CSimpleATLDLGController)
