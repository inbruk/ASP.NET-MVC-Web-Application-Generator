using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataTransferObjects.AppIdAndAuth.Authorization
{
    public class UIForm
    {
        public long RoleId { get; }
        public long SimpleEntityId { get; }
        public String ComplexEntityName { get; }
        public Boolean IsComplexEntity { get; }

        public Boolean AllowListForm { get; }

        public Boolean AllowListFormCreateOneButton { get; }
        public Boolean AllowListFormEditOneButton { get; }
        public Boolean AllowListFormDeleteOneButton { get; }

        public Boolean AllowListFormCreateMultipleButton { get; }
        public Boolean AllowListFormEditMultipleButton { get; }
        public Boolean AllowListFormDeleteMultipleButton { get; }

        public Boolean AllowEditFormReadOnly { get; }
        public Boolean AllowEditFormWithSave { get; }

        public UIForm(SimpleEntity simEnt)
        {
            RoleId = simEnt.RoleId;
            SimpleEntityId = simEnt.EntityId;
            IsComplexEntity = false;

            AllowListForm = simEnt.AllowMethodReadWithFilters;

            AllowListFormCreateOneButton = simEnt.AllowMethodCreateOne;
            AllowListFormEditOneButton = simEnt.AllowMethodUpdateOne;
            AllowListFormDeleteOneButton = simEnt.AllowMethodDeleteOne;

            AllowListFormCreateMultipleButton = simEnt.AllowMethodCreateMultiple;
            AllowListFormEditMultipleButton = simEnt.AllowMethodUpdateMultiple;
            AllowListFormDeleteMultipleButton = simEnt.AllowMethodDeleteMultiple;

            AllowEditFormReadOnly = simEnt.AllowMethodReadOne && (!simEnt.AllowMethodUpdateOne);
            AllowEditFormWithSave = simEnt.AllowMethodUpdateOne;
        }

        public UIForm(ComplexEntity cmplxEnt)
        {
            RoleId = cmplxEnt.RoleId;
            ComplexEntityName = cmplxEnt.ComplexEntityName;
            IsComplexEntity = true;

            AllowListForm = cmplxEnt.AllowMethodReadWithFilters;

            AllowListFormCreateOneButton = false;
            AllowListFormEditOneButton = false;
            AllowListFormDeleteOneButton = false;

            AllowListFormCreateMultipleButton = false;
            AllowListFormEditMultipleButton = false;
            AllowListFormDeleteMultipleButton = false;

            AllowEditFormReadOnly = false;
            AllowEditFormWithSave = false;
        }
    }
}
