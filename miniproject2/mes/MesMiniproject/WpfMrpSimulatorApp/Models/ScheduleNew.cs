using System;
using System.Collections.Generic;

namespace WpfMrpSimulatorApp.Models;

public partial class ScheduleNew
{
    /// <summary>
    /// 공정계획 순번(자동증가)
    /// </summary>
    public int SchIdx { get; set; }

    /// <summary>
    /// 공장코드
    /// </summary>
    public string PlantCode { get; set; } = null!;

    // 데이터 그리드에 표현하려면 새로운 속성이 필요!!
    public string PlantName { get; set; }

    public DateOnly SchDate { get; set; }

    /// <summary>
    /// 로드타임(초)
    /// </summary>
    public int LoadTime { get; set; }

    /// <summary>
    /// 계획된 시작 시간
    /// </summary>
    public TimeOnly? SchStratTime { get; set; }

    /// <summary>
    /// 계획된 종료 시간
    /// </summary>
    public TimeOnly? SchEndTime { get; set; }

    /// <summary>
    /// 계획 설비 ID
    /// </summary>
    public string? SchFacilityId { get; set; }

    public string? SchFacilityName { get; set; }

    /// <summary>
    /// 계획 목표 수량
    /// </summary>
    public int? SchAmount { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    public DateTime? RegDt { get; set; }

    /// <summary>
    /// 수정일
    /// 
    /// </summary>
    public DateTime? ModDt { get; set; }
}
