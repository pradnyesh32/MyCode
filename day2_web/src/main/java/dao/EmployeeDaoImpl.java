package dao;

import pojos.Department;
import pojos.Employee;
import org.hibernate.*;
import static utils.HibernateUtils.getFactory;

import java.io.Serializable;
import java.util.List;

public class EmployeeDaoImpl implements EmployeeDao {

	@Override
	public String addEmpDetails(Employee newEmp) {
		// newEmp : TRANSIENT
		String mesg = "Adding emp failed !!!!!!!!!!!!!!";
		// 1. get Session from SF(session factory)
		Session session = getFactory().getCurrentSession();
		// 2. Begin a tx
		Transaction tx = session.beginTransaction();
		try {
			// Session API : public Serializable save(Object
			// transientObjRef) throws HibernateExc.
			Long empId = (Long) session.save(newEmp);
			// newEmp : PERSISTENT => entity ref added to L1 cache
			tx.commit();// Hibernate perform auto. dirty chking --> session.flush()
			// DML --insert --session.close() => L1 cache destroyed ,
			// rets DB cn to the DBCP
			// (db connection pool)
			// newEmp : DETACHED (from L1 cache)
			mesg = "Added emp details , ID =" + empId;
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			// re throw the same exc to the caller :
			// so that caller will know about the exc
			throw e;
		}
		return mesg;
	}

	@Override
	public List<Employee> getEmpsByDeptAndSalary(Department dept, double minSal) {
		List<Employee> emps=null;
		String jpql="select e from Employee e where e.dept=:department and e.salary > :sal";
		// 1. get session from SF
		Session session = getFactory().getCurrentSession();
		// 2. begin a tx
		Transaction tx = session.beginTransaction();
		try {
			emps=session.createQuery(jpql,Employee.class).
					setParameter("department", dept).
					setParameter("sal", minSal).
					getResultList();
			tx.commit();
		} catch (RuntimeException e) {
			if (tx != null)
				tx.rollback();
			throw e;
		}
		return emps;
	}

}
