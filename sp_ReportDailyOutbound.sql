-- ============================================
-- Stored Procedure: sp_ReportDailyOutbound
-- Jalankan script ini di SSMS pada database DB_RMD_Sambu
-- ============================================

IF OBJECT_ID('dbo.sp_ReportDailyOutbound', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_ReportDailyOutbound;
GO

CREATE PROCEDURE [dbo].[sp_ReportDailyOutbound]
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT
        oi.issue_no       AS IssueNo,
        oi.created_at     AS IssueDate,
        oi.shift          AS Shift,
        oi.destination    AS Destination,
        mg.grade_name     AS GradeName,
        oid.qty           AS Qty,
        u.full_name       AS CreatedBy
    FROM OutboundIssues oi
    JOIN OutboundIssueDetails oid ON oid.issue_id = oi.id
    JOIN MaterialGrades mg        ON mg.id = oid.grade_id
    LEFT JOIN Users u             ON u.id = oi.created_by
    WHERE oi.created_at >= @StartDate
      AND oi.created_at <= @EndDate
    ORDER BY oi.created_at DESC;
END;
GO
