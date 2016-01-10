﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoinRpg.DataModel;

namespace JoinRpg.Data.Interfaces
{
  public interface IProjectRepository : IDisposable
  {
    Task<IEnumerable<Project>> GetActiveProjectsWithClaimCount();

    IEnumerable<Project> GetMyActiveProjects(int? userInfoId);

    Task<Project> GetProjectAsync(int project);
    Task<Project> GetProjectWithDetailsAsync(int project);
    Task<CharacterGroup> LoadGroupAsync(int projectId, int characterGroupId);
    Task<CharacterGroup> LoadGroupWithTreeAsync(int projectId, int characterGroupId);
    Task<CharacterGroup> LoadGroupWithChildsAsync(int projectId, int characterGroupId);
    Task<Character> GetCharacterAsync(int projectId, int characterId);
    Task<Character> GetCharacterWithGroups(int projectId, int characterId);
    Task<Claim> GetClaim(int projectId, int claimId);
    Task<Claim> GetClaimWithDetails(int projectId, int claimId);
    Task<IList<CharacterGroup>> LoadGroups(int projectId, ICollection<int> groupIds);
    Task<IList<Character>> LoadCharacters(int projectId, ICollection<int> characterIds);
    Task<ProjectCharacterField> GetProjectField(int projectId, int projectCharacterFieldId);
    Task<ProjectCharacterFieldDropdownValue> GetFieldValue(int projectId, int projectCharacterFieldDropdownValueId);
    Task<Project> GetProjectWithFinances(int projectid);
  }
}
