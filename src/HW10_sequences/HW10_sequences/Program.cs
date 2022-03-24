using HW10_sequences;

var entities = new List<Entity>
{
    new(1, 0, "Root entity"),
    new(2, 1, "Child of 1 entity"),
    new(3, 1, "Child of 1 entity"),
    new(4, 2, "Child of 2 entity"),
    new(5, 4, "Child of 4 entity")
};

var entitiesGroupingByParentId = entities.GroupToDictionary(entity => entity.ParentId);

foreach (var (parentId, groupingEntities) in entitiesGroupingByParentId)
{
    Console.WriteLine($"Key = {parentId}, Value = {groupingEntities.GetType().Name} {{ {string.Join(", ", groupingEntities)} }}");
}
