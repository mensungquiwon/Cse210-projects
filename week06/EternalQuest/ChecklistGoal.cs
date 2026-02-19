using System;
using System.Runtime.InteropServices.Java;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private readonly int _target;
        private readonly int _bonus;

        // Constructor for creating a new checklist goal
        public ChecklistGoal(string name, string description, string points, int target, int bonus)
            : base(name, description, points)
        {
            if (target <= 0)
                throw new ArgumentOutOfRangeException(nameof(target), "Target must be a positive number.");
            if (bonus < 0)
                throw new ArgumentOutOfRangeException(nameof(bonus), "Bonus cannot be negative.");

            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        // Optional: constructor used when loading from a save file
        public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted)
            : base(name, description, points)
        {
            if (target <= 0)
                throw new ArgumentOutOfRangeException(nameof(target), "Target must be a positive number.");
            if (bonus < 0)
                throw new ArgumentOutOfRangeException(nameof(bonus), "Bonus cannot be negative.");
            if (amountCompleted < 0)
                throw new ArgumentOutOfRangeException(nameof(amountCompleted), "AmountCompleted cannot be negative.");

            _target = target;
            _bonus = bonus;
            _amountCompleted = amountCompleted;
        }

        public override void RecordEvent()
        {
            // Increment progress each time the user records the event.
            // Keep it idempotent-friendly: do not exceed target if you want a hard cap.
            if (_amountCompleted < _target)
            {
                _amountCompleted++;
            }
            else
            {
                // If you prefer to allow over-completion counts, remove the if-guard above.
                // _amountCompleted++;
            }
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;  // <-- replace &gt;= with >=
        }

        public override string GetDetailsString()
        {
            string mark = IsComplete() ? "[X]" : "[ ]";
            return $"{mark} {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
        }
        public int Target => _target;
        public int Bonus => _bonus;
        public int AmountCompleted => _amountCompleted;
    }
}