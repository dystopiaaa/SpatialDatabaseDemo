USE InformationData

INSERT INTO sys_job(job_id,dept_id,job_name,job_location)
VALUES(1,101,'销售员',geography::STGeomFromText('POINT(122.423401 47.827006)',4326))

INSERT INTO sys_job(job_id,dept_id,job_name,job_location)
VALUES(2,101,'前台',geography::STGeomFromText('POINT(110.146687 34.547352)',4326))

INSERT INTO sys_job(job_id,dept_id,job_name,job_location)
VALUES(3,101,'部门主管',geography::STGeomFromText('POINT(115.014697 23.479204)',4326))

INSERT INTO sys_job(job_id,dept_id,job_name,job_location)
VALUES(4,102,'会计',geography::STGeomFromText('POINT(99.947938 22.672001)',4326))

INSERT INTO sys_job(job_id,dept_id,job_name,job_location)
VALUES(5,102,'设计师',geography::STGeomFromText('POINT(86.549201 46.879246)',4326))

INSERT INTO sys_job(job_id,dept_id,job_name,job_location)
VALUES(6,103,'工程师',geography::STGeomFromText('POINT(113.504921 35.001468)',4326))

GO
