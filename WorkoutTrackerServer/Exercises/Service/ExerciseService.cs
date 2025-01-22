﻿using WorkoutTrackerServer.Exercises.Dto;
using WorkoutTrackerServer.Exercises.Repository;
using WorkoutTrackerServer.Pagination;

namespace WorkoutTrackerServer.Exercises.Service;

public class ExerciseService : IExerciseService
{
    private readonly IExerciseRepository _exerciseRepository;
    
    public Task<Page<ExerciseDto>> GetExercises(int page, int pageSize)
    {
        return _exerciseRepository.getPage(page, pageSize);
    }

    public Task<ExerciseDto> GetExercise(long id)
    {
        throw new NotImplementedException();
    }

    public Task<CreateExerciseResponseDto> CreateExercise(CreateExerciseRequestDto createExerciseRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<ExerciseDto> UpdateExercise(long id, UpdateExerciseRequestDto updateExerciseRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteExercise(long id)
    {
        throw new NotImplementedException();
    }
}