using System.Collections.Generic;

namespace _Source.Core
{
    public class ResourceBank
    {
        private Dictionary<GameResource, ObservableInt> Resources { get; } = new Dictionary<GameResource, ObservableInt>()
        {
            {GameResource.Humans, new ObservableInt(0)},
            {GameResource.Food, new ObservableInt(0)},
            {GameResource.Wood, new ObservableInt(0)},
            {GameResource.Stone, new ObservableInt(0)},
            {GameResource.Gold, new ObservableInt(0)}
        };

        public void ChangeResource(GameResource resource, int value) {
            Resources[resource].Value += value;
        }

        public ObservableInt GetResource(GameResource resource) {
            return Resources[resource];
        }

    }
}


