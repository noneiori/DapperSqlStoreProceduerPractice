USE [mingkuan]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_TEST]    Script Date: 2024/5/5 上午 10:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[FN_TEST]
                (@id varchar(5))--傳入值
RETURNS @TABLE TABLE (--設定傳入值格式
                question varchar(500),
                answer Nvarchar(500),
                item Nvarchar(100))--設定回傳值格式
AS
BEGIN   
    --依據傳入id將查詢結果INSERT至@TABLE
    INSERT INTO @TABLE (question,answer)
    select question,answer
    from QandA
    where id=@id

    --將@TABLE中2個欄位合併並更新至Item欄位
    UPDATE @TABLE
    SET item=question+':'+answer

    RETURN--回傳
END