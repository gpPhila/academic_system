using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace academic_system
{
	// This is the base class that AdminManager, TeacherManager, and StudentManager will inherit from.
	public abstract class BaseManager
	{
		// ---- USER METHODS ----

		// Method to get a user by ID
		public virtual void GetUserById() { }

		// Method to show the profile of the logged-in user
		public virtual void ShowUserProfile() { }


		// ---- STUDENT METHODS ----

		public virtual void CreateStudent() { }

		public virtual void DeleteStudent() { }

		public virtual void GetAllStudents() { }


		// ---- TEACHER METHODS ----

		public virtual void CreateTeacher() { }

		public virtual void DeleteTeacher() { }

		public virtual void GetAllTeachers() { }


		// ---- GROUP METHODS ----

		public virtual void CreateGroup() { }

		public virtual void DeleteGroup() { }

		public virtual void GetAllGroups() { }

		public virtual void AssignStudentToGroup() { }

		public virtual void AssignSubjectToGroup() { }


		// ---- SUBJECT METHODS ----

		public virtual void CreateSubject() { }

		public virtual void DeleteSubject() { }

		public virtual void GetAllSubjects() { }

		public virtual void AssignTeacherToSubject() { }


		// ---- GRADE METHODS ----

		public virtual void AddGrade() { }

		public virtual void EditGrade() { }

		public virtual void ViewGradesByStudent() { }

		public virtual void ViewGradesBySubject() { }


		// ---- ROLE DASHBOARD ----

		// This method *must* be implemented by the child classes (AdminManager/TeacherManager/StudentManager)
		public abstract void ShowRoleDashboard();
	}
}
