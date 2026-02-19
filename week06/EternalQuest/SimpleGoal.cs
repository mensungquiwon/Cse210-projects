using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string shortName, string description, string points)
            : base(shortName, description, points)
        {
            _isComplete = false;
        }

        public SimpleGoal(string shortName, string description, string points, bool isComplete)
            : base(shortName, description, points)
        {
            _isComplete = isComplete;
        }

        public override void RecordEvent()
        {
            if (_isComplete) return;
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

    
        public override string GetDetailsString()
        {
            string mark = _isComplete ? "[X]" : "[ ]";
            return $"{mark} {GetShortName()}: {GetDescription()} ({GetPoints()} points)";
        }

        // Use a consistent, easy-to-parse format for save/load.
        // Format: SimpleGoal|Name|Description|Points|IsComplete
        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
        }
    }
}