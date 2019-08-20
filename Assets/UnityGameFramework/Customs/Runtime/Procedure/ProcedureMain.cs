//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using System.Collections.Generic;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace UnityGameFramework
{
    public class ProcedureMain : ProcedureBase
    {
     
        public override bool UseNativeDialog
        {
            get
            {
                return false;
            }
        }
    }
}
