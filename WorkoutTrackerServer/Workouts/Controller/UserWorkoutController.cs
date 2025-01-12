﻿using Microsoft.AspNetCore.Mvc;
using WorkoutTrackerServer.Workouts.Dto;

namespace WorkoutTrackerServer.Workouts.Controller;

/// <summary>
/// Operations for a given user's workouts.
/// </summary>
[ApiController]
[Route("users/{userId}/workouts")]
public class UserWorkoutController
{
    /// <summary>
    /// Get basic data of the user's workouts from the given time period
    /// </summary>
    /// <param name="userId" example="100">ID of the user</param>
    /// <param name="from">Start date of the period to get workouts from (inclusive)</param>
    /// <param name="to" optional="true">End date of the period to get workouts from (inclusive)</param>
    /// <response code="200"></response>
    [HttpGet]
    public List<WorkoutDto> GetWorkoutsOfUser([FromRoute] string userId, [FromQuery] DateOnly from, [FromQuery] DateOnly to)
    {
        return [];
    }
}