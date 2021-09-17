using TwitchOVR.Enums;

namespace TwitchOVR.Models
{
    public class ObsReward
    {
        public uint Id { get; }
        public string RewardId { get; set; }
        public float Delay { get; set; }
        public string SourceName { get; set; }
        public string SceneName { get; set; }
        public ObsSourceType SourceType { get; set; }
        public ObsEventType EventType { get; set; }

        public override string ToString()
        {
            return $"({Id.ToString()}) {RewardId} ({SourceName}, {SceneName})";
        }

        public override bool Equals(object obj)
        {
            return obj is ObsReward obsReward && Id == obsReward.Id;
        }

        public static bool operator ==(ObsReward obsReward1, ObsReward obsReward2)
        {
            if (obsReward1 is null && obsReward2 is null)
            {
                return true;
            }

            return !(obsReward1 is null) && obsReward1.Equals(obsReward2);
        }

        public static bool operator !=(ObsReward obsReward1, ObsReward obsReward2)
        {
            return !(obsReward1 == obsReward2);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}