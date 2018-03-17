namespace Auxiliary.CRUD
{
    using System;

    public interface IFilterItem
    {
        String FieldName { get; }
        enFilterItemTypes ItemType { get; }
        enFilterItemValueTypes ValueType { get; }
        enFilterItemCondition ItemCondition { get; }
    }
}
