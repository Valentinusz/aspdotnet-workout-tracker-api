﻿using System.ComponentModel.DataAnnotations;
using WorkoutTrackerServer.WorkoutSets;

namespace WorkoutTrackerServer.Workouts;

/// <summary>
/// Entity representing a workout
/// </summary>
public class Workout
{
    /// <summary>
    /// ID of the workout
    /// </summary>
    [Key]
    public int Id { get; set; }

    [Required] public DateTime StartTime { get; set; }

    public List<WorkoutSet> WorkoutSets { get; set; } = [];

}