namespace Domain
{
    public class EntityGroupSubscription
    {
        public string Name => Entity.Name;

        public Entity Entity { get; private set; }

        public string Probability { get; set; }

        public EntityGroupSubscription(Entity entity, string probability)
        {
            Entity = entity;
            Probability = probability;
        }

        public void SetEntity(Entity entity)
        {
            Entity = entity;
        }
    }
}
